namespace xqemu_gui
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.tbxGamesPath = new System.Windows.Forms.TextBox();
            this.btnGamesSelect = new System.Windows.Forms.Button();
            this.lblGamesPath = new System.Windows.Forms.Label();
            this.lblMCPXPath = new System.Windows.Forms.Label();
            this.btnMCPXSelect = new System.Windows.Forms.Button();
            this.tbxMCPXPath = new System.Windows.Forms.TextBox();
            this.lblBIOSPath = new System.Windows.Forms.Label();
            this.btnBIOSSelect = new System.Windows.Forms.Button();
            this.tbxBIOSPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHDDSelect = new System.Windows.Forms.Button();
            this.tbxHDDPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.openMCPXDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectGamesFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openBIOSDialog = new System.Windows.Forms.OpenFileDialog();
            this.openHDDDialog = new System.Windows.Forms.OpenFileDialog();
            this.tctOptions = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.cbxController4 = new System.Windows.Forms.ComboBox();
            this.cbxController3 = new System.Windows.Forms.ComboBox();
            this.cbxController2 = new System.Windows.Forms.ComboBox();
            this.cbxController1 = new System.Windows.Forms.ComboBox();
            this.lblController1 = new System.Windows.Forms.Label();
            this.lblController4 = new System.Windows.Forms.Label();
            this.lblController3 = new System.Windows.Forms.Label();
            this.lblController2 = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tctOptions.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxGamesPath
            // 
            this.tbxGamesPath.Location = new System.Drawing.Point(18, 33);
            this.tbxGamesPath.Name = "tbxGamesPath";
            this.tbxGamesPath.Size = new System.Drawing.Size(190, 20);
            this.tbxGamesPath.TabIndex = 1;
            // 
            // btnGamesSelect
            // 
            this.btnGamesSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGamesSelect.AutoSize = true;
            this.btnGamesSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGamesSelect.Location = new System.Drawing.Point(214, 31);
            this.btnGamesSelect.Name = "btnGamesSelect";
            this.btnGamesSelect.Size = new System.Drawing.Size(26, 23);
            this.btnGamesSelect.TabIndex = 2;
            this.btnGamesSelect.Text = "...";
            this.btnGamesSelect.UseVisualStyleBackColor = true;
            this.btnGamesSelect.Click += new System.EventHandler(this.BtnGamesSelect_Click);
            // 
            // lblGamesPath
            // 
            this.lblGamesPath.AutoSize = true;
            this.lblGamesPath.Location = new System.Drawing.Point(18, 17);
            this.lblGamesPath.Name = "lblGamesPath";
            this.lblGamesPath.Size = new System.Drawing.Size(69, 13);
            this.lblGamesPath.TabIndex = 99;
            this.lblGamesPath.Text = "Games folder";
            // 
            // lblMCPXPath
            // 
            this.lblMCPXPath.AutoSize = true;
            this.lblMCPXPath.Location = new System.Drawing.Point(18, 67);
            this.lblMCPXPath.Name = "lblMCPXPath";
            this.lblMCPXPath.Size = new System.Drawing.Size(56, 13);
            this.lblMCPXPath.TabIndex = 99;
            this.lblMCPXPath.Text = "MCPX File";
            // 
            // btnMCPXSelect
            // 
            this.btnMCPXSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMCPXSelect.AutoSize = true;
            this.btnMCPXSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMCPXSelect.Location = new System.Drawing.Point(214, 81);
            this.btnMCPXSelect.Name = "btnMCPXSelect";
            this.btnMCPXSelect.Size = new System.Drawing.Size(26, 23);
            this.btnMCPXSelect.TabIndex = 4;
            this.btnMCPXSelect.Text = "...";
            this.btnMCPXSelect.UseVisualStyleBackColor = true;
            this.btnMCPXSelect.Click += new System.EventHandler(this.BtnMCPXSelect_Click);
            // 
            // tbxMCPXPath
            // 
            this.tbxMCPXPath.Location = new System.Drawing.Point(18, 83);
            this.tbxMCPXPath.Name = "tbxMCPXPath";
            this.tbxMCPXPath.Size = new System.Drawing.Size(190, 20);
            this.tbxMCPXPath.TabIndex = 3;
            // 
            // lblBIOSPath
            // 
            this.lblBIOSPath.AutoSize = true;
            this.lblBIOSPath.Location = new System.Drawing.Point(18, 118);
            this.lblBIOSPath.Name = "lblBIOSPath";
            this.lblBIOSPath.Size = new System.Drawing.Size(51, 13);
            this.lblBIOSPath.TabIndex = 99;
            this.lblBIOSPath.Text = "BIOS File";
            // 
            // btnBIOSSelect
            // 
            this.btnBIOSSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBIOSSelect.AutoSize = true;
            this.btnBIOSSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBIOSSelect.Location = new System.Drawing.Point(214, 132);
            this.btnBIOSSelect.Name = "btnBIOSSelect";
            this.btnBIOSSelect.Size = new System.Drawing.Size(26, 23);
            this.btnBIOSSelect.TabIndex = 6;
            this.btnBIOSSelect.Text = "...";
            this.btnBIOSSelect.UseVisualStyleBackColor = true;
            this.btnBIOSSelect.Click += new System.EventHandler(this.BtnBIOSSelect_Click);
            // 
            // tbxBIOSPath
            // 
            this.tbxBIOSPath.Location = new System.Drawing.Point(18, 134);
            this.tbxBIOSPath.Name = "tbxBIOSPath";
            this.tbxBIOSPath.Size = new System.Drawing.Size(190, 20);
            this.tbxBIOSPath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "HDD Image";
            // 
            // btnHDDSelect
            // 
            this.btnHDDSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHDDSelect.AutoSize = true;
            this.btnHDDSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHDDSelect.Location = new System.Drawing.Point(214, 182);
            this.btnHDDSelect.Name = "btnHDDSelect";
            this.btnHDDSelect.Size = new System.Drawing.Size(26, 23);
            this.btnHDDSelect.TabIndex = 8;
            this.btnHDDSelect.Text = "...";
            this.btnHDDSelect.UseVisualStyleBackColor = true;
            this.btnHDDSelect.Click += new System.EventHandler(this.BtnHDDSelect_Click);
            // 
            // tbxHDDPath
            // 
            this.tbxHDDPath.Location = new System.Drawing.Point(18, 184);
            this.tbxHDDPath.Name = "tbxHDDPath";
            this.tbxHDDPath.Size = new System.Drawing.Size(190, 20);
            this.tbxHDDPath.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(170, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openMCPXDialog
            // 
            this.openMCPXDialog.FileName = "MCPX file";
            this.openMCPXDialog.Filter = "MCPX files (*.bin)|*.bin";
            this.openMCPXDialog.Title = "Open MCPX file";
            // 
            // openBIOSDialog
            // 
            this.openBIOSDialog.Filter = "XBox BIOS files (*.bin)|*.bin";
            this.openBIOSDialog.Title = "Open BIOS file";
            // 
            // openHDDDialog
            // 
            this.openHDDDialog.Filter = "XBox HDD image  (*.qcow2)|*.qcow2";
            this.openHDDDialog.Title = "Open HDD image";
            // 
            // tctOptions
            // 
            this.tctOptions.Controls.Add(this.tabInput);
            this.tctOptions.Controls.Add(this.tabGeneral);
            this.tctOptions.Location = new System.Drawing.Point(1, 0);
            this.tctOptions.Name = "tctOptions";
            this.tctOptions.SelectedIndex = 0;
            this.tctOptions.Size = new System.Drawing.Size(268, 245);
            this.tctOptions.TabIndex = 0;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.cbxController4);
            this.tabInput.Controls.Add(this.cbxController3);
            this.tabInput.Controls.Add(this.cbxController2);
            this.tabInput.Controls.Add(this.cbxController1);
            this.tabInput.Controls.Add(this.lblController1);
            this.tabInput.Controls.Add(this.lblController4);
            this.tabInput.Controls.Add(this.lblController3);
            this.tabInput.Controls.Add(this.lblController2);
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(260, 219);
            this.tabInput.TabIndex = 2;
            this.tabInput.Text = "Input";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // cbxController4
            // 
            this.cbxController4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxController4.FormattingEnabled = true;
            this.cbxController4.Items.AddRange(new object[] {
            "(None)",
            "Original XBox Controller",
            "XBox360, DS4 Controller",
            "Keyboard"});
            this.cbxController4.Location = new System.Drawing.Point(18, 183);
            this.cbxController4.Name = "cbxController4";
            this.cbxController4.Size = new System.Drawing.Size(190, 21);
            this.cbxController4.TabIndex = 4;
            // 
            // cbxController3
            // 
            this.cbxController3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxController3.FormattingEnabled = true;
            this.cbxController3.Items.AddRange(new object[] {
            "(None)",
            "Original XBox Controller",
            "XBox360, DS4 Controller",
            "Keyboard"});
            this.cbxController3.Location = new System.Drawing.Point(18, 133);
            this.cbxController3.Name = "cbxController3";
            this.cbxController3.Size = new System.Drawing.Size(190, 21);
            this.cbxController3.TabIndex = 3;
            // 
            // cbxController2
            // 
            this.cbxController2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxController2.FormattingEnabled = true;
            this.cbxController2.Items.AddRange(new object[] {
            "(None)",
            "Original XBox Controller",
            "XBox360, DS4 Controller",
            "Keyboard"});
            this.cbxController2.Location = new System.Drawing.Point(18, 83);
            this.cbxController2.Name = "cbxController2";
            this.cbxController2.Size = new System.Drawing.Size(190, 21);
            this.cbxController2.TabIndex = 2;
            // 
            // cbxController1
            // 
            this.cbxController1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxController1.FormattingEnabled = true;
            this.cbxController1.Items.AddRange(new object[] {
            "(None)",
            "Original XBox Controller",
            "XBox360, DS4 Controller",
            "Keyboard"});
            this.cbxController1.Location = new System.Drawing.Point(18, 32);
            this.cbxController1.Name = "cbxController1";
            this.cbxController1.Size = new System.Drawing.Size(190, 21);
            this.cbxController1.TabIndex = 1;
            // 
            // lblController1
            // 
            this.lblController1.AutoSize = true;
            this.lblController1.Location = new System.Drawing.Point(18, 17);
            this.lblController1.Name = "lblController1";
            this.lblController1.Size = new System.Drawing.Size(60, 13);
            this.lblController1.TabIndex = 99;
            this.lblController1.Text = "Controller 1";
            // 
            // lblController4
            // 
            this.lblController4.AutoSize = true;
            this.lblController4.Location = new System.Drawing.Point(18, 168);
            this.lblController4.Name = "lblController4";
            this.lblController4.Size = new System.Drawing.Size(60, 13);
            this.lblController4.TabIndex = 99;
            this.lblController4.Text = "Controller 4";
            // 
            // lblController3
            // 
            this.lblController3.AutoSize = true;
            this.lblController3.Location = new System.Drawing.Point(18, 118);
            this.lblController3.Name = "lblController3";
            this.lblController3.Size = new System.Drawing.Size(60, 13);
            this.lblController3.TabIndex = 99;
            this.lblController3.Text = "Controller 3";
            // 
            // lblController2
            // 
            this.lblController2.AutoSize = true;
            this.lblController2.Location = new System.Drawing.Point(18, 67);
            this.lblController2.Name = "lblController2";
            this.lblController2.Size = new System.Drawing.Size(60, 13);
            this.lblController2.TabIndex = 99;
            this.lblController2.Text = "Controller 2";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.lblGamesPath);
            this.tabGeneral.Controls.Add(this.tbxGamesPath);
            this.tabGeneral.Controls.Add(this.btnGamesSelect);
            this.tabGeneral.Controls.Add(this.btnBIOSSelect);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Controls.Add(this.tbxBIOSPath);
            this.tabGeneral.Controls.Add(this.tbxMCPXPath);
            this.tabGeneral.Controls.Add(this.lblBIOSPath);
            this.tabGeneral.Controls.Add(this.btnHDDSelect);
            this.tabGeneral.Controls.Add(this.lblMCPXPath);
            this.tabGeneral.Controls.Add(this.btnMCPXSelect);
            this.tabGeneral.Controls.Add(this.tbxHDDPath);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(260, 219);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 280);
            this.Controls.Add(this.tctOptions);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.tctOptions.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxGamesPath;
        private System.Windows.Forms.Button btnGamesSelect;
        private System.Windows.Forms.Label lblGamesPath;
        private System.Windows.Forms.Label lblMCPXPath;
        private System.Windows.Forms.Button btnMCPXSelect;
        private System.Windows.Forms.TextBox tbxMCPXPath;
        private System.Windows.Forms.Label lblBIOSPath;
        private System.Windows.Forms.Button btnBIOSSelect;
        private System.Windows.Forms.TextBox tbxBIOSPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHDDSelect;
        private System.Windows.Forms.TextBox tbxHDDPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openMCPXDialog;
        private System.Windows.Forms.FolderBrowserDialog selectGamesFolderDialog;
        private System.Windows.Forms.OpenFileDialog openBIOSDialog;
        private System.Windows.Forms.OpenFileDialog openHDDDialog;
        private System.Windows.Forms.TabControl tctOptions;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.ComboBox cbxController4;
        private System.Windows.Forms.ComboBox cbxController3;
        private System.Windows.Forms.ComboBox cbxController2;
        private System.Windows.Forms.ComboBox cbxController1;
        private System.Windows.Forms.Label lblController1;
        private System.Windows.Forms.Label lblController4;
        private System.Windows.Forms.Label lblController3;
        private System.Windows.Forms.Label lblController2;
    }
}