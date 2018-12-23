using System;
using System.IO;
using System.Windows.Forms;
using Nini.Config;

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
    }
}
