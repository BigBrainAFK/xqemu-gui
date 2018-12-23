using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Nini.Config;

namespace xqemu_gui
{
    public partial class Main : Form
    {
        private IniConfigSource configSource;
        private IConfig configGeneral;
        private IConfig configController;
        string selectedISO = "";
        bool skipAnim = false;

        public Main()
        {
            InitializeComponent();

            LoadConfigs();

            selectedISO = configGeneral.GetString("Recent_ISO", "");
            lblLoaded.Text = selectedISO.Length > 0 ? selectedISO : "No ISO selected. This will launch the XBox Dashboard.";

            skipAnim = configGeneral.GetBoolean("Skip_Animation", false);
            menuSkipAnimation.Checked = skipAnim;
        }

        private void MenuOptions_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            Options OptionDialog = new Options();
            OptionDialog.Show();

            OptionDialog.FormClosed += new FormClosedEventHandler(Form_Close);

        }

        private void Form_Close(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void MenuOpenFile_Click(object sender, EventArgs e)
        {
            string tempGamesFolder = configGeneral.GetString("Games_Folder", "");

            openISODialog.InitialDirectory = selectedISO.Length > 0
                ? Path.GetDirectoryName(selectedISO)
                : tempGamesFolder.Length > 0
                    ? tempGamesFolder
                    : Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            DialogResult result = openISODialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedISO = openISODialog.FileName;
                lblLoaded.Text = selectedISO;
                configGeneral.Set("Recent_ISO", selectedISO);
                configSource.Save();
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadConfigs()
        {
            configSource = new IniConfigSource(@".\launcher_config.ini");

            if (configSource.Configs["default"] != null)
            {
                configGeneral = configSource.Configs["default"];
            }
            else
            {
                SetDefaultGeneral(configSource);
            }

            if (configSource.Configs["controller"] != null)
            {
                configController = configSource.Configs["controller"];
            }
            else
            {
                SetDefaultController(configSource);
            }
        }

        private void SetDefaultGeneral(IniConfigSource configSource)
        {
            if (configSource.Configs["default"] == null) configSource.AddConfig("default");

            configGeneral = configSource.Configs["default"];

            configGeneral.Set("Recent_ISO", "");
            configGeneral.Set("Skip_Animation", false);
            configGeneral.Set("Games_Folder", "");
            configGeneral.Set("MCPX", "");
            configGeneral.Set("BIOS", "");
            configGeneral.Set("HDD", "");
            configSource.Save();
        }

        private void SetDefaultController(IniConfigSource configSource)
        {
            if (configSource.Configs["controller"] == null) configSource.AddConfig("controller");

            configController = configSource.Configs["controller"];

            configController.Set("Controller1", 1);
            configController.Set("Controller2", 0);
            configController.Set("Controller3", 0);
            configController.Set("Controller4", 0);
            configSource.Save();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string MCPX = configGeneral.GetString("MCPX", "");
            if (MCPX.Length == 0)
            {
                MessageBox.Show(
                    "No MCPX file seleced. Please go into the options and select one!",
                    "No MCPX file selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string BIOS = configGeneral.GetString("BIOS", "");
            if (BIOS.Length == 0)
            {
                MessageBox.Show(
                    "No BIOS file seleced. Please go into the options and select one!",
                    "No BIOS file selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string HDD = configGeneral.GetString("HDD", "");
            if (HDD.Length == 0)
            {
                MessageBox.Show(
                    "No HDD image seleced. Please go into the options and select one!",
                    "No HDD image selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            bool launchDash = false;
            if (selectedISO.Length == 0)
            {
                launchDash = true;
            }

            string skipAnims = menuSkipAnimation.Checked ? ",short-animation" : "";

            string usb = BuildUSBInput();

            Process xqemu = new Process();
            xqemu.StartInfo.FileName = @".\xqemu.exe";
            xqemu.StartInfo.Arguments = " -cpu pentium3"
                + $" -machine xbox,bootrom={MCPX.Replace(@"\", @"\\")}{skipAnims}"
                + " -m 64"
                + $" -bios \"{BIOS.Replace(@"\", @"\\")}\""
                + $" -drive index=0,media=disk,file={HDD.Replace(@"\", @"\\")},locked"
                + " -drive index=1,media=cdrom," + ( launchDash ? "" : $"file={selectedISO.Replace(@"\", @"\\")}" )
                + $" -usb{usb}";
            xqemu.Start();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(@".\xqemu.exe"))
            {
                if (MessageBox.Show(
                    "XQEMU not found in the folder! Please put this in the same folder as XQEMU!",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    ) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void MenuSkipAnimation_Click(object sender, EventArgs e)
        {
            configGeneral.Set("Skip_Animation", menuSkipAnimation.Checked);
            configSource.Save();
        }

        private string BuildUSBInput()
        {
            string build = "";
            string[] magicTable = { "", "usb-host", "usb-xbox-gamepad-sdl", "usb-xbox-gamepad" };

            int[] controllers = {
                configController.GetInt("Controller3", 0) > 3 ? 0 : configController.GetInt("Controller3", 0),
                configController.GetInt("Controller4", 0) > 3 ? 0 : configController.GetInt("Controller4", 0),
                configController.GetInt("Controller1", 1) > 3 ? 1 : configController.GetInt("Controller1", 1),
                configController.GetInt("Controller2", 0) > 3 ? 0 : configController.GetInt("Controller2", 0),
            };

            int sdlIndex = 0;
            int port = 0;

            foreach (int controller in controllers)
            {
                ++port;
                switch (controller)
                {
                    case 1:
                        continue; //build support for usb passthrough of original xbox controller
                    case 2:
                        build += $" -device {magicTable[controller]},index={sdlIndex},port={port}";
                        ++sdlIndex;
                        break;
                    case 3:
                        build += $" -device {magicTable[controller]},port={port}";
                        break;
                    default:
                        continue;
                }
            }

            if (build == "") build += "-device usb-xbox-gamepad,port=3";

            return build;
        }

        private void EjectISOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedISO = "";
            lblLoaded.Text = "No ISO selected. This will launch the XBox Dashboard.";
            configGeneral.Set("Recent_ISO", selectedISO);
            configSource.Save();
        }
    }
}
