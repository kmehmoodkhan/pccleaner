namespace PCCleaner.Controls.Options
{
    partial class UCAdvanced
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxEnableWindowJumpList = new System.Windows.Forms.CheckBox();
            this.checkBoxSkipUserControlWarning = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveToINIFile = new System.Windows.Forms.CheckBox();
            this.checkBoxMinimizeToSystemTray = new System.Windows.Forms.CheckBox();
            this.checkBoxShowPromptBackupRegistry = new System.Windows.Forms.CheckBox();
            this.checkBoxShutdowAfterCleaning = new System.Windows.Forms.CheckBox();
            this.checkBoxCloseProgramOnCleaning = new System.Windows.Forms.CheckBox();
            this.checkBoxHideWarning = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteRecycleBin = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteTempFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxShowResultDetail = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxEnableWindowJumpList);
            this.panel1.Controls.Add(this.checkBoxSkipUserControlWarning);
            this.panel1.Controls.Add(this.checkBoxSaveToINIFile);
            this.panel1.Controls.Add(this.checkBoxMinimizeToSystemTray);
            this.panel1.Controls.Add(this.checkBoxShowPromptBackupRegistry);
            this.panel1.Controls.Add(this.checkBoxShutdowAfterCleaning);
            this.panel1.Controls.Add(this.checkBoxCloseProgramOnCleaning);
            this.panel1.Controls.Add(this.checkBoxHideWarning);
            this.panel1.Controls.Add(this.checkBoxDeleteRecycleBin);
            this.panel1.Controls.Add(this.checkBoxDeleteTempFiles);
            this.panel1.Controls.Add(this.checkBoxShowResultDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 525);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxEnableWindowJumpList
            // 
            this.checkBoxEnableWindowJumpList.AutoSize = true;
            this.checkBoxEnableWindowJumpList.Location = new System.Drawing.Point(23, 423);
            this.checkBoxEnableWindowJumpList.Name = "checkBoxEnableWindowJumpList";
            this.checkBoxEnableWindowJumpList.Size = new System.Drawing.Size(233, 21);
            this.checkBoxEnableWindowJumpList.TabIndex = 27;
            this.checkBoxEnableWindowJumpList.Text = "Enable Window Jump List Tasks";
            this.checkBoxEnableWindowJumpList.UseVisualStyleBackColor = true;
            this.checkBoxEnableWindowJumpList.CheckedChanged += new System.EventHandler(this.checkBoxEnableWindowJumpList_CheckedChanged);
            // 
            // checkBoxSkipUserControlWarning
            // 
            this.checkBoxSkipUserControlWarning.AutoSize = true;
            this.checkBoxSkipUserControlWarning.Location = new System.Drawing.Point(23, 383);
            this.checkBoxSkipUserControlWarning.Name = "checkBoxSkipUserControlWarning";
            this.checkBoxSkipUserControlWarning.Size = new System.Drawing.Size(197, 21);
            this.checkBoxSkipUserControlWarning.TabIndex = 26;
            this.checkBoxSkipUserControlWarning.Text = "Skip User Control warning ";
            this.checkBoxSkipUserControlWarning.UseVisualStyleBackColor = true;
            this.checkBoxSkipUserControlWarning.CheckedChanged += new System.EventHandler(this.checkBoxSkipUserControlWarning_CheckedChanged);
            // 
            // checkBoxSaveToINIFile
            // 
            this.checkBoxSaveToINIFile.AutoSize = true;
            this.checkBoxSaveToINIFile.Location = new System.Drawing.Point(23, 343);
            this.checkBoxSaveToINIFile.Name = "checkBoxSaveToINIFile";
            this.checkBoxSaveToINIFile.Size = new System.Drawing.Size(191, 21);
            this.checkBoxSaveToINIFile.TabIndex = 25;
            this.checkBoxSaveToINIFile.Text = "Save all settings to INI file";
            this.checkBoxSaveToINIFile.UseVisualStyleBackColor = true;
            this.checkBoxSaveToINIFile.CheckedChanged += new System.EventHandler(this.checkBoxSaveToINIFile_CheckedChanged);
            // 
            // checkBoxMinimizeToSystemTray
            // 
            this.checkBoxMinimizeToSystemTray.AutoSize = true;
            this.checkBoxMinimizeToSystemTray.Location = new System.Drawing.Point(23, 303);
            this.checkBoxMinimizeToSystemTray.Name = "checkBoxMinimizeToSystemTray";
            this.checkBoxMinimizeToSystemTray.Size = new System.Drawing.Size(183, 21);
            this.checkBoxMinimizeToSystemTray.TabIndex = 24;
            this.checkBoxMinimizeToSystemTray.Text = "Minimize to System Tray";
            this.checkBoxMinimizeToSystemTray.UseVisualStyleBackColor = true;
            this.checkBoxMinimizeToSystemTray.CheckedChanged += new System.EventHandler(this.checkBoxMinimizeToSystemTray_CheckedChanged);
            // 
            // checkBoxShowPromptBackupRegistry
            // 
            this.checkBoxShowPromptBackupRegistry.AutoSize = true;
            this.checkBoxShowPromptBackupRegistry.Location = new System.Drawing.Point(23, 263);
            this.checkBoxShowPromptBackupRegistry.Name = "checkBoxShowPromptBackupRegistry";
            this.checkBoxShowPromptBackupRegistry.Size = new System.Drawing.Size(273, 21);
            this.checkBoxShowPromptBackupRegistry.TabIndex = 23;
            this.checkBoxShowPromptBackupRegistry.Text = "Show prompt to backup registry issues";
            this.checkBoxShowPromptBackupRegistry.UseVisualStyleBackColor = true;
            this.checkBoxShowPromptBackupRegistry.CheckedChanged += new System.EventHandler(this.checkBoxShowPromptBackupRegistry_CheckedChanged);
            // 
            // checkBoxShutdowAfterCleaning
            // 
            this.checkBoxShutdowAfterCleaning.AutoSize = true;
            this.checkBoxShutdowAfterCleaning.Location = new System.Drawing.Point(23, 223);
            this.checkBoxShutdowAfterCleaning.Name = "checkBoxShutdowAfterCleaning";
            this.checkBoxShutdowAfterCleaning.Size = new System.Drawing.Size(182, 21);
            this.checkBoxShutdowAfterCleaning.TabIndex = 22;
            this.checkBoxShutdowAfterCleaning.Text = "Shutdown after cleaning";
            this.checkBoxShutdowAfterCleaning.UseVisualStyleBackColor = true;
            this.checkBoxShutdowAfterCleaning.CheckedChanged += new System.EventHandler(this.checkBoxShutdowAfterCleaning_CheckedChanged);
            // 
            // checkBoxCloseProgramOnCleaning
            // 
            this.checkBoxCloseProgramOnCleaning.AutoSize = true;
            this.checkBoxCloseProgramOnCleaning.Location = new System.Drawing.Point(23, 183);
            this.checkBoxCloseProgramOnCleaning.Name = "checkBoxCloseProgramOnCleaning";
            this.checkBoxCloseProgramOnCleaning.Size = new System.Drawing.Size(212, 21);
            this.checkBoxCloseProgramOnCleaning.TabIndex = 21;
            this.checkBoxCloseProgramOnCleaning.Text = "Close program after cleaning";
            this.checkBoxCloseProgramOnCleaning.UseVisualStyleBackColor = true;
            this.checkBoxCloseProgramOnCleaning.CheckedChanged += new System.EventHandler(this.checkBoxCloseProgramOnCleaning_CheckedChanged);
            // 
            // checkBoxHideWarning
            // 
            this.checkBoxHideWarning.AutoSize = true;
            this.checkBoxHideWarning.Location = new System.Drawing.Point(23, 143);
            this.checkBoxHideWarning.Name = "checkBoxHideWarning";
            this.checkBoxHideWarning.Size = new System.Drawing.Size(180, 21);
            this.checkBoxHideWarning.TabIndex = 20;
            this.checkBoxHideWarning.Text = "Hide warning messages";
            this.checkBoxHideWarning.UseVisualStyleBackColor = true;
            this.checkBoxHideWarning.CheckedChanged += new System.EventHandler(this.checkBoxHideWarning_CheckedChanged);
            // 
            // checkBoxDeleteRecycleBin
            // 
            this.checkBoxDeleteRecycleBin.AutoSize = true;
            this.checkBoxDeleteRecycleBin.Location = new System.Drawing.Point(23, 103);
            this.checkBoxDeleteRecycleBin.Name = "checkBoxDeleteRecycleBin";
            this.checkBoxDeleteRecycleBin.Size = new System.Drawing.Size(352, 21);
            this.checkBoxDeleteRecycleBin.TabIndex = 19;
            this.checkBoxDeleteRecycleBin.Text = "Only delete files in Recycle Bin older than 24 hours";
            this.checkBoxDeleteRecycleBin.UseVisualStyleBackColor = true;
            this.checkBoxDeleteRecycleBin.CheckedChanged += new System.EventHandler(this.checkBoxDeleteRecycleBin_CheckedChanged);
            // 
            // checkBoxDeleteTempFiles
            // 
            this.checkBoxDeleteTempFiles.AutoSize = true;
            this.checkBoxDeleteTempFiles.Location = new System.Drawing.Point(23, 63);
            this.checkBoxDeleteTempFiles.Name = "checkBoxDeleteTempFiles";
            this.checkBoxDeleteTempFiles.Size = new System.Drawing.Size(317, 21);
            this.checkBoxDeleteTempFiles.TabIndex = 18;
            this.checkBoxDeleteTempFiles.Text = "Only delete files in temp folder older 24 hours";
            this.checkBoxDeleteTempFiles.UseVisualStyleBackColor = true;
            this.checkBoxDeleteTempFiles.CheckedChanged += new System.EventHandler(this.checkBoxDeleteTempFiles_CheckedChanged);
            // 
            // checkBoxShowResultDetail
            // 
            this.checkBoxShowResultDetail.AutoSize = true;
            this.checkBoxShowResultDetail.Location = new System.Drawing.Point(23, 23);
            this.checkBoxShowResultDetail.Name = "checkBoxShowResultDetail";
            this.checkBoxShowResultDetail.Size = new System.Drawing.Size(210, 21);
            this.checkBoxShowResultDetail.TabIndex = 17;
            this.checkBoxShowResultDetail.Text = "Show results in detailed view";
            this.checkBoxShowResultDetail.UseVisualStyleBackColor = true;
            this.checkBoxShowResultDetail.CheckedChanged += new System.EventHandler(this.checkBoxShowResultDetail_CheckedChanged);
            // 
            // UCAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCAdvanced";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(787, 531);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxSaveToINIFile;
        private System.Windows.Forms.CheckBox checkBoxMinimizeToSystemTray;
        private System.Windows.Forms.CheckBox checkBoxShowPromptBackupRegistry;
        private System.Windows.Forms.CheckBox checkBoxShutdowAfterCleaning;
        private System.Windows.Forms.CheckBox checkBoxCloseProgramOnCleaning;
        private System.Windows.Forms.CheckBox checkBoxHideWarning;
        private System.Windows.Forms.CheckBox checkBoxDeleteRecycleBin;
        private System.Windows.Forms.CheckBox checkBoxDeleteTempFiles;
        private System.Windows.Forms.CheckBox checkBoxShowResultDetail;
        private System.Windows.Forms.CheckBox checkBoxEnableWindowJumpList;
        private System.Windows.Forms.CheckBox checkBoxSkipUserControlWarning;
    }
}
