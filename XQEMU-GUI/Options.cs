using System;
using System.IO;
using System.Windows.Forms;
using Nini.Config;

namespace XQEMU_GUI
{
    public partial class Options : Form
    {
        private IniConfigSource configSource;
        private IConfig config;

        public Options()
        {
            InitializeComponent();
            if (!File.Exists(@".\launcher_config.ini")) File.Create(@".\launcher_config.ini");

            LoadConfigs();

            tbxGamesPath.Text = config.GetString("Games_Folder", "");
            selectGamesFolderDialog.SelectedPath = tbxGamesPath.Text.Length > 0 
                ? tbxGamesPath.Text 
                : Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            tbxMCPXPath.Text = config.GetString("MCPX", "");
            openMCPXDialog.InitialDirectory = tbxMCPXPath.Text.Length > 0 
                ? Path.GetDirectoryName(tbxMCPXPath.Text) 
                : Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            tbxBIOSPath.Text = config.GetString("BIOS", "");
            openBIOSDialog.InitialDirectory = tbxBIOSPath.Text.Length > 0 
                ? Path.GetDirectoryName(tbxBIOSPath.Text) 
                : Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            tbxHDDPath.Text = config.GetString("HDD", "");
            openHDDDialog.InitialDirectory = tbxHDDPath.Text.Length > 0
                ? Path.GetDirectoryName(tbxHDDPath.Text)
                : Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
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

            config.Set("Games_Folder", tbxGamesPath.Text);
            config.Set("MCPX", tbxMCPXPath.Text);
            config.Set("BIOS", tbxBIOSPath.Text);
            config.Set("HDD", tbxHDDPath.Text);

            configSource.Save();
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

            config.Set("Games_Folder", "");
            config.Set("MCPX", "");
            config.Set("BIOS", "");
            config.Set("HDD", "");
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
