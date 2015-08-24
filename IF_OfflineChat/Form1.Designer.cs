namespace IF_OfflineChat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonChat = new System.Windows.Forms.Button();
            this.groupBoxAvanzate = new System.Windows.Forms.GroupBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.checkBoxAvanzateEnabled = new System.Windows.Forms.CheckBox();
            this.labelAvanzateInfo = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.browseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.creditsADP = new System.Windows.Forms.LinkLabel();
            this.creditsInforge = new System.Windows.Forms.PictureBox();
            this.groupBoxAvanzate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditsInforge)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(384, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Inforge.net - League of Legends Offline Chat";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChat
            // 
            this.buttonChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChat.Location = new System.Drawing.Point(142, 41);
            this.buttonChat.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(100, 23);
            this.buttonChat.TabIndex = 1;
            this.buttonChat.Text = "Blocca Chat";
            this.buttonChat.UseVisualStyleBackColor = true;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // groupBoxAvanzate
            // 
            this.groupBoxAvanzate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAvanzate.Controls.Add(this.buttonBrowse);
            this.groupBoxAvanzate.Controls.Add(this.textBoxDirectory);
            this.groupBoxAvanzate.Controls.Add(this.labelDirectory);
            this.groupBoxAvanzate.Controls.Add(this.checkBoxAvanzateEnabled);
            this.groupBoxAvanzate.Controls.Add(this.labelAvanzateInfo);
            this.groupBoxAvanzate.Location = new System.Drawing.Point(12, 70);
            this.groupBoxAvanzate.Name = "groupBoxAvanzate";
            this.groupBoxAvanzate.Size = new System.Drawing.Size(360, 86);
            this.groupBoxAvanzate.TabIndex = 2;
            this.groupBoxAvanzate.TabStop = false;
            this.groupBoxAvanzate.Text = "Blocco Avanzato";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Enabled = false;
            this.buttonBrowse.Location = new System.Drawing.Point(329, 58);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(24, 20);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Enabled = false;
            this.textBoxDirectory.Location = new System.Drawing.Point(83, 58);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(240, 20);
            this.textBoxDirectory.TabIndex = 3;
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(7, 61);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(70, 13);
            this.labelDirectory.TabIndex = 2;
            this.labelDirectory.Text = "Directory LoL";
            // 
            // checkBoxAvanzateEnabled
            // 
            this.checkBoxAvanzateEnabled.AutoSize = true;
            this.checkBoxAvanzateEnabled.Location = new System.Drawing.Point(10, 36);
            this.checkBoxAvanzateEnabled.Name = "checkBoxAvanzateEnabled";
            this.checkBoxAvanzateEnabled.Size = new System.Drawing.Size(53, 17);
            this.checkBoxAvanzateEnabled.TabIndex = 1;
            this.checkBoxAvanzateEnabled.Text = "Attiva";
            this.checkBoxAvanzateEnabled.UseVisualStyleBackColor = true;
            this.checkBoxAvanzateEnabled.CheckedChanged += new System.EventHandler(this.checkBoxAvanzateEnabled_CheckedChanged);
            // 
            // labelAvanzateInfo
            // 
            this.labelAvanzateInfo.AutoSize = true;
            this.labelAvanzateInfo.Location = new System.Drawing.Point(7, 20);
            this.labelAvanzateInfo.Name = "labelAvanzateInfo";
            this.labelAvanzateInfo.Size = new System.Drawing.Size(316, 13);
            this.labelAvanzateInfo.TabIndex = 0;
            this.labelAvanzateInfo.Text = "Se non funziona normalmente il tool, attivare la modalità Avanzata";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelStatus.Location = new System.Drawing.Point(248, 41);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 23);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status: Online";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browseFolder
            // 
            this.browseFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.browseFolder.ShowNewFolderButton = false;
            // 
            // creditsADP
            // 
            this.creditsADP.AutoSize = true;
            this.creditsADP.Location = new System.Drawing.Point(12, 189);
            this.creditsADP.Name = "creditsADP";
            this.creditsADP.Size = new System.Drawing.Size(70, 13);
            this.creditsADP.TabIndex = 5;
            this.creditsADP.TabStop = true;
            this.creditsADP.Text = "By AlessioDP";
            this.creditsADP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsADP_LinkClicked);
            // 
            // creditsInforge
            // 
            this.creditsInforge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditsInforge.Image = global::OfflineChat.Properties.Resources.if_credits;
            this.creditsInforge.Location = new System.Drawing.Point(184, 160);
            this.creditsInforge.Name = "creditsInforge";
            this.creditsInforge.Size = new System.Drawing.Size(200, 50);
            this.creditsInforge.TabIndex = 4;
            this.creditsInforge.TabStop = false;
            this.creditsInforge.Click += new System.EventHandler(this.creditsInforge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.creditsADP);
            this.Controls.Add(this.creditsInforge);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.groupBoxAvanzate);
            this.Controls.Add(this.buttonChat);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offline Chat - Inforge.net";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAvanzate.ResumeLayout(false);
            this.groupBoxAvanzate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditsInforge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonChat;
        private System.Windows.Forms.GroupBox groupBoxAvanzate;
        private System.Windows.Forms.CheckBox checkBoxAvanzateEnabled;
        private System.Windows.Forms.Label labelAvanzateInfo;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.PictureBox creditsInforge;
        private System.Windows.Forms.LinkLabel creditsADP;
    }
}
