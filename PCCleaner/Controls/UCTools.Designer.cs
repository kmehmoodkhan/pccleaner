namespace PCCleaner.Controls.Common
{
    partial class UCTools
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
            this.flowLayoutPanelTools = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStartup = new System.Windows.Forms.Button();
            this.buttonUninstall = new System.Windows.Forms.Button();
            this.buttonPlugins = new System.Windows.Forms.Button();
            this.buttonDisk = new System.Windows.Forms.Button();
            this.buttonDuplicate = new System.Windows.Forms.Button();
            this.buttonSystemRestore = new System.Windows.Forms.Button();
            this.buttonDriveWiper = new System.Windows.Forms.Button();
            this.panelInfoBar = new System.Windows.Forms.Panel();
            this.labelNotice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInformation = new System.Windows.Forms.Label();
            this.panelToolsMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTools.SuspendLayout();
            this.panelInfoBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTools
            // 
            this.flowLayoutPanelTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelTools.Controls.Add(this.buttonUninstall);
            this.flowLayoutPanelTools.Controls.Add(this.buttonStartup);
            this.flowLayoutPanelTools.Controls.Add(this.buttonPlugins);
            this.flowLayoutPanelTools.Controls.Add(this.buttonDisk);
            this.flowLayoutPanelTools.Controls.Add(this.buttonDuplicate);
            this.flowLayoutPanelTools.Controls.Add(this.buttonSystemRestore);
            this.flowLayoutPanelTools.Controls.Add(this.buttonDriveWiper);
            this.flowLayoutPanelTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelTools.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTools.Name = "flowLayoutPanelTools";
            this.flowLayoutPanelTools.Size = new System.Drawing.Size(215, 354);
            this.flowLayoutPanelTools.TabIndex = 0;
            // 
            // buttonStartup
            // 
            this.buttonStartup.Location = new System.Drawing.Point(3, 54);
            this.buttonStartup.Name = "buttonStartup";
            this.buttonStartup.Size = new System.Drawing.Size(205, 45);
            this.buttonStartup.TabIndex = 1;
            this.buttonStartup.Text = "Startup";
            this.buttonStartup.UseVisualStyleBackColor = true;
            // 
            // buttonUninstall
            // 
            this.buttonUninstall.Location = new System.Drawing.Point(3, 3);
            this.buttonUninstall.Name = "buttonUninstall";
            this.buttonUninstall.Size = new System.Drawing.Size(205, 45);
            this.buttonUninstall.TabIndex = 0;
            this.buttonUninstall.Text = "Uninstall";
            this.buttonUninstall.UseVisualStyleBackColor = true;
            this.buttonUninstall.Click += new System.EventHandler(this.buttonUninstall_Click);
            // 
            // buttonPlugins
            // 
            this.buttonPlugins.Location = new System.Drawing.Point(3, 105);
            this.buttonPlugins.Name = "buttonPlugins";
            this.buttonPlugins.Size = new System.Drawing.Size(205, 45);
            this.buttonPlugins.TabIndex = 2;
            this.buttonPlugins.Text = "Plugins";
            this.buttonPlugins.UseVisualStyleBackColor = true;
            // 
            // buttonDisk
            // 
            this.buttonDisk.Location = new System.Drawing.Point(3, 156);
            this.buttonDisk.Name = "buttonDisk";
            this.buttonDisk.Size = new System.Drawing.Size(205, 45);
            this.buttonDisk.TabIndex = 3;
            this.buttonDisk.Text = "Disk Analyzer";
            this.buttonDisk.UseVisualStyleBackColor = true;
            // 
            // buttonDuplicate
            // 
            this.buttonDuplicate.Location = new System.Drawing.Point(3, 207);
            this.buttonDuplicate.Name = "buttonDuplicate";
            this.buttonDuplicate.Size = new System.Drawing.Size(205, 45);
            this.buttonDuplicate.TabIndex = 4;
            this.buttonDuplicate.Text = "Duplicate Finder";
            this.buttonDuplicate.UseVisualStyleBackColor = true;
            // 
            // buttonSystemRestore
            // 
            this.buttonSystemRestore.Location = new System.Drawing.Point(3, 258);
            this.buttonSystemRestore.Name = "buttonSystemRestore";
            this.buttonSystemRestore.Size = new System.Drawing.Size(205, 45);
            this.buttonSystemRestore.TabIndex = 5;
            this.buttonSystemRestore.Text = "System Restore";
            this.buttonSystemRestore.UseVisualStyleBackColor = true;
            // 
            // buttonDriveWiper
            // 
            this.buttonDriveWiper.Location = new System.Drawing.Point(3, 309);
            this.buttonDriveWiper.Name = "buttonDriveWiper";
            this.buttonDriveWiper.Size = new System.Drawing.Size(205, 45);
            this.buttonDriveWiper.TabIndex = 6;
            this.buttonDriveWiper.Text = "Drive Wiper";
            this.buttonDriveWiper.UseVisualStyleBackColor = true;
            // 
            // panelInfoBar
            // 
            this.panelInfoBar.Controls.Add(this.labelNotice);
            this.panelInfoBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoBar.Location = new System.Drawing.Point(215, 0);
            this.panelInfoBar.Name = "panelInfoBar";
            this.panelInfoBar.Size = new System.Drawing.Size(842, 45);
            this.panelInfoBar.TabIndex = 1;
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotice.Location = new System.Drawing.Point(47, 9);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(523, 20);
            this.labelNotice.TabIndex = 0;
            this.labelNotice.Text = "Select a program from the list you want to remove from the computer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCCleaner.Properties.Resources.Information;
            this.pictureBox1.Location = new System.Drawing.Point(233, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(263, 9);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(523, 20);
            this.labelInformation.TabIndex = 0;
            this.labelInformation.Text = "Select a program from the list you want to remove from the computer";
            // 
            // panelToolsMain
            // 
            this.panelToolsMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelToolsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToolsMain.Location = new System.Drawing.Point(215, 45);
            this.panelToolsMain.Name = "panelToolsMain";
            this.panelToolsMain.Size = new System.Drawing.Size(842, 309);
            this.panelToolsMain.TabIndex = 2;
            // 
            // UCTools
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelToolsMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelInfoBar);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.flowLayoutPanelTools);
            this.Name = "UCTools";
            this.Size = new System.Drawing.Size(1057, 354);
            this.flowLayoutPanelTools.ResumeLayout(false);
            this.panelInfoBar.ResumeLayout(false);
            this.panelInfoBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTools;
        private System.Windows.Forms.Button buttonUninstall;
        private System.Windows.Forms.Button buttonStartup;
        private System.Windows.Forms.Button buttonPlugins;
        private System.Windows.Forms.Button buttonDisk;
        private System.Windows.Forms.Button buttonDuplicate;
        private System.Windows.Forms.Button buttonSystemRestore;
        private System.Windows.Forms.Button buttonDriveWiper;
        private System.Windows.Forms.Panel panelInfoBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Panel panelToolsMain;
        private System.Windows.Forms.Label labelNotice;
    }
}
