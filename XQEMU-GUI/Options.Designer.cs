namespace XQEMU_GUI
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
            this.SuspendLayout();
            // 
            // tbxGamesPath
            // 
            this.tbxGamesPath.Location = new System.Drawing.Point(12, 25);
            this.tbxGamesPath.Name = "tbxGamesPath";
            this.tbxGamesPath.Size = new System.Drawing.Size(190, 20);
            this.tbxGamesPath.TabIndex = 0;
            // 
            // btnGamesSelect
            // 
            this.btnGamesSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGamesSelect.AutoSize = true;
            this.btnGamesSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGamesSelect.Location = new System.Drawing.Point(208, 23);
            this.btnGamesSelect.Name = "btnGamesSelect";
            this.btnGamesSelect.Size = new System.Drawing.Size(26, 23);
            this.btnGamesSelect.TabIndex = 1;
            this.btnGamesSelect.Text = "...";
            this.btnGamesSelect.UseVisualStyleBackColor = true;
            this.btnGamesSelect.Click += new System.EventHandler(this.BtnGamesSelect_Click);
            // 
            // lblGamesPath
            // 
            this.lblGamesPath.AutoSize = true;
            this.lblGamesPath.Location = new System.Drawing.Point(12, 9);
            this.lblGamesPath.Name = "lblGamesPath";
            this.lblGamesPath.Size = new System.Drawing.Size(69, 13);
            this.lblGamesPath.TabIndex = 99;
            this.lblGamesPath.Text = "Games folder";
            // 
            // lblMCPXPath
            // 
            this.lblMCPXPath.AutoSize = true;
            this.lblMCPXPath.Location = new System.Drawing.Point(12, 59);
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
            this.btnMCPXSelect.Location = new System.Drawing.Point(208, 73);
            this.btnMCPXSelect.Name = "btnMCPXSelect";
            this.btnMCPXSelect.Size = new System.Drawing.Size(26, 23);
            this.btnMCPXSelect.TabIndex = 3;
            this.btnMCPXSelect.Text = "...";
            this.btnMCPXSelect.UseVisualStyleBackColor = true;
            this.btnMCPXSelect.Click += new System.EventHandler(this.BtnMCPXSelect_Click);
            // 
            // tbxMCPXPath
            // 
            this.tbxMCPXPath.Location = new System.Drawing.Point(12, 75);
            this.tbxMCPXPath.Name = "tbxMCPXPath";
            this.tbxMCPXPath.Size = new System.Drawing.Size(190, 20);
            this.tbxMCPXPath.TabIndex = 2;
            // 
            // lblBIOSPath
            // 
            this.lblBIOSPath.AutoSize = true;
            this.lblBIOSPath.Location = new System.Drawing.Point(12, 110);
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
            this.btnBIOSSelect.Location = new System.Drawing.Point(208, 124);
            this.btnBIOSSelect.Name = "btnBIOSSelect";
            this.btnBIOSSelect.Size = new System.Drawing.Size(26, 23);
            this.btnBIOSSelect.TabIndex = 5;
            this.btnBIOSSelect.Text = "...";
            this.btnBIOSSelect.UseVisualStyleBackColor = true;
            this.btnBIOSSelect.Click += new System.EventHandler(this.BtnBIOSSelect_Click);
            // 
            // tbxBIOSPath
            // 
            this.tbxBIOSPath.Location = new System.Drawing.Point(12, 126);
            this.tbxBIOSPath.Name = "tbxBIOSPath";
            this.tbxBIOSPath.Size = new System.Drawing.Size(190, 20);
            this.tbxBIOSPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
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
            this.btnHDDSelect.Location = new System.Drawing.Point(208, 174);
            this.btnHDDSelect.Name = "btnHDDSelect";
            this.btnHDDSelect.Size = new System.Drawing.Size(26, 23);
            this.btnHDDSelect.TabIndex = 7;
            this.btnHDDSelect.Text = "...";
            this.btnHDDSelect.UseVisualStyleBackColor = true;
            this.btnHDDSelect.Click += new System.EventHandler(this.BtnHDDSelect_Click);
            // 
            // tbxHDDPath
            // 
            this.tbxHDDPath.Location = new System.Drawing.Point(12, 176);
            this.tbxHDDPath.Name = "tbxHDDPath";
            this.tbxHDDPath.Size = new System.Drawing.Size(190, 20);
            this.tbxHDDPath.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(159, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
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
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 240);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHDDSelect);
            this.Controls.Add(this.tbxHDDPath);
            this.Controls.Add(this.lblBIOSPath);
            this.Controls.Add(this.btnBIOSSelect);
            this.Controls.Add(this.tbxBIOSPath);
            this.Controls.Add(this.lblMCPXPath);
            this.Controls.Add(this.btnMCPXSelect);
            this.Controls.Add(this.tbxMCPXPath);
            this.Controls.Add(this.lblGamesPath);
            this.Controls.Add(this.btnGamesSelect);
            this.Controls.Add(this.tbxGamesPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}