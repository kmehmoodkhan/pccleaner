namespace PCCleaner.Controls
{
    partial class UCOptions
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
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonCookies = new System.Windows.Forms.Button();
            this.buttonInclude = new System.Windows.Forms.Button();
            this.buttonExclude = new System.Windows.Forms.Button();
            this.buttonAdvanced = new System.Windows.Forms.Button();
            this.buttonSubscription = new System.Windows.Forms.Button();
            this.buttonAboutUs = new System.Windows.Forms.Button();
            this.panelToolsMain = new System.Windows.Forms.Panel();
            this.panelInfoBar = new System.Windows.Forms.Panel();
            this.labelNotice = new System.Windows.Forms.Label();
            this.flowLayoutPanelTools.SuspendLayout();
            this.panelInfoBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTools
            // 
            this.flowLayoutPanelTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelTools.Controls.Add(this.buttonSettings);
            this.flowLayoutPanelTools.Controls.Add(this.buttonCookies);
            this.flowLayoutPanelTools.Controls.Add(this.buttonInclude);
            this.flowLayoutPanelTools.Controls.Add(this.buttonExclude);
            this.flowLayoutPanelTools.Controls.Add(this.buttonAdvanced);
            this.flowLayoutPanelTools.Controls.Add(this.buttonSubscription);
            this.flowLayoutPanelTools.Controls.Add(this.buttonAboutUs);
            this.flowLayoutPanelTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelTools.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTools.Name = "flowLayoutPanelTools";
            this.flowLayoutPanelTools.Size = new System.Drawing.Size(215, 374);
            this.flowLayoutPanelTools.TabIndex = 1;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(3, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(205, 45);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonCookies
            // 
            this.buttonCookies.Location = new System.Drawing.Point(3, 54);
            this.buttonCookies.Name = "buttonCookies";
            this.buttonCookies.Size = new System.Drawing.Size(205, 45);
            this.buttonCookies.TabIndex = 1;
            this.buttonCookies.Text = "Cookies";
            this.buttonCookies.UseVisualStyleBackColor = true;
            this.buttonCookies.Click += new System.EventHandler(this.buttonCookies_Click);
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(3, 105);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(205, 45);
            this.buttonInclude.TabIndex = 2;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonInclude_Click);
            // 
            // buttonExclude
            // 
            this.buttonExclude.Location = new System.Drawing.Point(3, 156);
            this.buttonExclude.Name = "buttonExclude";
            this.buttonExclude.Size = new System.Drawing.Size(205, 45);
            this.buttonExclude.TabIndex = 3;
            this.buttonExclude.Text = "Exclude";
            this.buttonExclude.UseVisualStyleBackColor = true;
            this.buttonExclude.Click += new System.EventHandler(this.buttonExclude_Click);
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.Location = new System.Drawing.Point(3, 207);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(205, 45);
            this.buttonAdvanced.TabIndex = 6;
            this.buttonAdvanced.Text = "Advanced";
            this.buttonAdvanced.UseVisualStyleBackColor = true;
            this.buttonAdvanced.Click += new System.EventHandler(this.buttonAdvanced_Click);
            // 
            // buttonSubscription
            // 
            this.buttonSubscription.Location = new System.Drawing.Point(3, 258);
            this.buttonSubscription.Name = "buttonSubscription";
            this.buttonSubscription.Size = new System.Drawing.Size(205, 45);
            this.buttonSubscription.TabIndex = 7;
            this.buttonSubscription.Text = "Subscription";
            this.buttonSubscription.UseVisualStyleBackColor = true;
            this.buttonSubscription.Click += new System.EventHandler(this.buttonSubscription_Click);
            // 
            // buttonAboutUs
            // 
            this.buttonAboutUs.Location = new System.Drawing.Point(3, 309);
            this.buttonAboutUs.Name = "buttonAboutUs";
            this.buttonAboutUs.Size = new System.Drawing.Size(205, 45);
            this.buttonAboutUs.TabIndex = 8;
            this.buttonAboutUs.Text = "About";
            this.buttonAboutUs.UseVisualStyleBackColor = true;
            this.buttonAboutUs.Click += new System.EventHandler(this.buttonAboutUs_Click);
            // 
            // panelToolsMain
            // 
            this.panelToolsMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelToolsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToolsMain.Location = new System.Drawing.Point(215, 45);
            this.panelToolsMain.Name = "panelToolsMain";
            this.panelToolsMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelToolsMain.Size = new System.Drawing.Size(731, 329);
            this.panelToolsMain.TabIndex = 4;
            // 
            // panelInfoBar
            // 
            this.panelInfoBar.Controls.Add(this.labelNotice);
            this.panelInfoBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoBar.Location = new System.Drawing.Point(215, 0);
            this.panelInfoBar.Name = "panelInfoBar";
            this.panelInfoBar.Size = new System.Drawing.Size(731, 45);
            this.panelInfoBar.TabIndex = 3;
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
            // UCOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelToolsMain);
            this.Controls.Add(this.panelInfoBar);
            this.Controls.Add(this.flowLayoutPanelTools);
            this.Name = "UCOptions";
            this.Size = new System.Drawing.Size(946, 374);
            this.flowLayoutPanelTools.ResumeLayout(false);
            this.panelInfoBar.ResumeLayout(false);
            this.panelInfoBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTools;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonCookies;
        private System.Windows.Forms.Button buttonInclude;
        private System.Windows.Forms.Button buttonExclude;
        private System.Windows.Forms.Button buttonAdvanced;
        private System.Windows.Forms.Panel panelToolsMain;
        private System.Windows.Forms.Panel panelInfoBar;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.Button buttonSubscription;
        private System.Windows.Forms.Button buttonAboutUs;
    }
}
