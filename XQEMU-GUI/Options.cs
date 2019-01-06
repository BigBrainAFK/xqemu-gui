using System;
using System.IO;
using System.Windows.Forms;
using Nini.Config;

/*
    -drive if=none,id=C1A,file=/mnt/c/temp/mu1.bin,format=raw \
    -drive if=none,id=C1B,file=/mnt/c/temp/mu2.bin,format=raw \
 
    -device usb-hub,bus=usb-bus.1,port=3 \   -- controller on port 1
    -device usb-xbox-gamepad,port=3.2 \      -- X.2 -- controller
    -device usb-storage,port=3.4,drive=C1A \ -- X.4 -- "MU port A"
    -device usb-storage,port=3.3,drive=C1B \ -- X.3 -- "MU port B"
 */

namespace xqemu_gui
{
    public partial class Options : Form
    {
        private IniConfigSource configSource;
        private IConfig configGeneral;
        private IConfig configController;

        public Options()
        {
            InitializeComponent();
            if (!File.Exists(@".\launcher_config.ini")) File.Create(@".\launcher_config.ini");

            LoadConfigs();

            tbxGamesPath.Text = configGeneral.GetString("Games_Folder", "");
            selectGamesFolderDialog.SelectedPath = tbxGamesPath.Text.Length > 0 
                ? tbxGamesPath.Text 
                : Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            tbxMCPXPath.Text = configGeneral.GetString("MCPX", "");
            openMCPXDialog.InitialDirectory = tbxMCPXPath.Text.Length > 0 
                ? Path.GetDirectoryName(tbxMCPXPath.Text) 
                : Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            tbxBIOSPath.Text = configGeneral.GetString("BIOS", "");
            openBIOSDialog.InitialDirectory = tbxBIOSPath.Text.Length > 0 
                ? Path.GetDirectoryName(tbxBIOSPath.Text) 
                : Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            tbxHDDPath.Text = configGeneral.GetString("HDD", "");
            openHDDDialog.InitialDirectory = tbxHDDPath.Text.Length > 0
                ? Path.GetDirectoryName(tbxHDDPath.Text)
                : Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            cbxController1.SelectedIndex = configController.GetInt("Controller1", 1);

            cbxController2.SelectedIndex = configController.GetInt("Controller2", 0);

            cbxController3.SelectedIndex = configController.GetInt("Controller3", 0);

            cbxController4.SelectedIndex = configController.GetInt("Controller4", 0);
        }

        private void BtnGamesSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = selectGamesFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbxGamesPath.Text = selectGamesFolderDialog.SelectedPath;
            }
        }

        private void BtnMCPXSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = openMCPXDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbxMCPXPath.Text = openMCPXDialog.FileName;
            }
        }

        private void BtnBIOSSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = openBIOSDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbxBIOSPath.Text = openBIOSDialog.FileName;
            }
        }

        private void BtnHDDSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = openHDDDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbxHDDPath.Text = openHDDDialog.FileName;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            VerifyPaths();

            configGeneral.Set("Games_Folder", tbxGamesPath.Text);
            configGeneral.Set("MCPX", tbxMCPXPath.Text);
            configGeneral.Set("BIOS", tbxBIOSPath.Text);
            configGeneral.Set("HDD", tbxHDDPath.Text);
            configController.Set("Controller1", cbxController1.SelectedIndex);
            configController.Set("Controller2", cbxController2.SelectedIndex);
            configController.Set("Controller3", cbxController3.SelectedIndex);
            configController.Set("Controller4", cbxController4.SelectedIndex);

            configSource.Save();
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
            configGeneral.Set("HAXM_Acceleration", false);
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

        private Boolean VerifyPaths()
        {
            if (!Directory.Exists(tbxGamesPath.Text)) return false;
            if (!File.Exists(tbxMCPXPath.Text)) return false;
            if (!File.Exists(tbxBIOSPath.Text)) return false;
            if (!File.Exists(tbxHDDPath.Text)) return false;

            return true;
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
                        build += $" -device usb-hub,bus=usb-bus.1,port=3 -device {magicTable[controller]},index={sdlIndex},port={port}.2";
                        ++sdlIndex;
                        break;
                    case 3:
                        build += $" -device usb-hub,bus=usb-bus.1,port=3 -device {magicTable[controller]},port={port}.2";
                        break;
                    default:
                        continue;
                }
            }

            if (build == "") build += "-device usb-xbox-gamepad,port=3";

            return build;
        }

        private void TabCLI_Enter(object sender, EventArgs e)
        {
            string MCPX = configGeneral.GetString("MCPX", "");
            string BIOS = configGeneral.GetString("BIOS", "");
            string HDD = configGeneral.GetString("HDD", "");

            string selectedISO = configGeneral.GetString("Recent_ISO", "");
            bool launchDash = false;
            if (selectedISO.Length == 0)
            {
                launchDash = true;
            }

            string skipAnimString = configGeneral.GetBoolean("Skip_Animation", false) ? ",short-animation" : "";
            string accel = configGeneral.GetBoolean("HAXM_Acceleration", false) ? ",accel=haxm:tcg" : "";
            string gl = configGeneral.GetBoolean("GL", false) ? ",gl=on" : "";

            string usb = BuildUSBInput();

            tbxPreview.Text = ".\\xqemu.exe -cpu pentium3"
                + $" -machine \"xbox,bootrom={MCPX.Replace("\\", "/")}{skipAnimString}{accel}\""
                + " -m 64"
                + $" -bios \"{BIOS.Replace("\\", "/")}\""
                + $" -drive \"index=0,media=disk,file={HDD.Replace("\\", "/")},locked\""
                + " -drive \"index=1,media=cdrom," + (launchDash ? "" : $"file={selectedISO.Replace("\\", "/")}") + "\""
                + $" -usb{usb}"
                + $" -display sdl{gl}";
        }
    }
}
