using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Nini.Config;

namespace XQEMU_GUI
{
    public partial class Main : Form
    {
        private IniConfigSource configSource;
        private IConfig config;
        string selectedISO = "";

        public Main()
        {
            InitializeComponent();

            LoadConfigs();

            selectedISO = config.GetString("Recent_ISO", "");
            if (selectedISO.Length > 0) lblLoaded.Text = selectedISO;
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
            string tempGamesFolder = config.GetString("Games_Folder", "");

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
                config.Set("Recent_ISO", selectedISO);
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
                config = configSource.Configs["default"];
            }
            else
            {
                SetDefault(configSource);
            }
        }

        private void SetDefault(IniConfigSource configSource)
        {
            if (configSource.Configs["default"] == null) configSource.AddConfig("default");

            config = configSource.Configs["default"];

            config.Set("Recent_ISO", "");
            configSource.Save();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string MCPX = config.GetString("MCPX", "");
            if (MCPX.Length == 0)
            {
                MessageBox.Show(
                    "No MCPX file seleced. Please go into the options and select one!",
                    "No MCPX file selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string BIOS = config.GetString("BIOS", "");
            if (BIOS.Length == 0)
            {
                MessageBox.Show(
                    "No BIOS file seleced. Please go into the options and select one!",
                    "No BIOS file selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string HDD = config.GetString("HDD", "");
            if (HDD.Length == 0)
            {
                MessageBox.Show(
                    "No HDD image seleced. Please go into the options and select one!",
                    "No HDD image selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (selectedISO.Length == 0)
            {
                MessageBox.Show(
                    "No ISO seleced. Please open one!",
                    "No ISO selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string skipAnims = menuSkipAnimation.Checked ? ",short-animation" : "";

            Process xqemu = new Process();
            xqemu.StartInfo.FileName = @".\xqemu.exe";
            xqemu.StartInfo.Arguments = " -cpu pentium3"
                + $" -machine xbox,bootrom={MCPX.Replace(@"\", @"\\")}{skipAnims}"
                + " -m 64"
                + $" -bios \"{BIOS.Replace(@"\", @"\\")}\""
                + $" -drive index=0,media=disk,file={HDD.Replace(@"\", @"\\")},locked"
                + $" -drive index=1,media=cdrom,file={selectedISO.Replace(@"\", @"\\")}"
                + " -usb -device usb-xbox-gamepad";
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
    }
}
