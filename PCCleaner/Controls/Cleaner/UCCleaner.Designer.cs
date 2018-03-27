namespace PCCleaner.Controls
{
    partial class UCCleaner
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
            this.ucEdge1 = new PCCleaner.Controls.UCEdge();
            this.tabPageWin = new System.Windows.Forms.TabPage();
            this.ucAdvanced1 = new PCCleaner.Controls.Cleaner.Windows.UCAdvanced();
            this.ucSystem1 = new PCCleaner.Controls.Cleaner.Windows.UCSystem();
            this.ucExplorer1 = new PCCleaner.Controls.Cleaner.Windows.UCExplorer();
            this.ucie2 = new PCCleaner.Controls.UCIE();
            this.tabPageApps = new System.Windows.Forms.TabPage();
            this.tabControlCleaner = new System.Windows.Forms.TabControl();
            this.panelNonWindowsApps = new System.Windows.Forms.Panel();
            this.tabPageWin.SuspendLayout();
            this.tabPageApps.SuspendLayout();
            this.tabControlCleaner.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucEdge1
            // 
            this.ucEdge1.CheckedAll = false;
            this.ucEdge1.Location = new System.Drawing.Point(0, 0);
            this.ucEdge1.Name = "ucEdge1";
            this.ucEdge1.Size = new System.Drawing.Size(262, 224);
            this.ucEdge1.TabIndex = 7;
            // 
            // tabPageWin
            // 
            this.tabPageWin.AutoScroll = true;
            this.tabPageWin.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageWin.Controls.Add(this.ucAdvanced1);
            this.tabPageWin.Controls.Add(this.ucSystem1);
            this.tabPageWin.Controls.Add(this.ucExplorer1);
            this.tabPageWin.Controls.Add(this.ucEdge1);
            this.tabPageWin.Controls.Add(this.ucie2);
            this.tabPageWin.Location = new System.Drawing.Point(4, 34);
            this.tabPageWin.Name = "tabPageWin";
            this.tabPageWin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWin.Size = new System.Drawing.Size(268, 1113);
            this.tabPageWin.TabIndex = 0;
            this.tabPageWin.Text = "Windows";
            // 
            // ucAdvanced1
            // 
            this.ucAdvanced1.CheckedAll = false;
            this.ucAdvanced1.Location = new System.Drawing.Point(0, 839);
            this.ucAdvanced1.Name = "ucAdvanced1";
            this.ucAdvanced1.Size = new System.Drawing.Size(262, 240);
            this.ucAdvanced1.TabIndex = 13;
            // 
            // ucSystem1
            // 
            this.ucSystem1.CheckedAll = false;
            this.ucSystem1.Location = new System.Drawing.Point(0, 593);
            this.ucSystem1.Name = "ucSystem1";
            this.ucSystem1.Size = new System.Drawing.Size(262, 240);
            this.ucSystem1.TabIndex = 11;
            // 
            // ucExplorer1
            // 
            this.ucExplorer1.BackColor = System.Drawing.SystemColors.Control;
            this.ucExplorer1.CheckedAll = false;
            this.ucExplorer1.Location = new System.Drawing.Point(3, 440);
            this.ucExplorer1.Name = "ucExplorer1";
            this.ucExplorer1.Size = new System.Drawing.Size(262, 151);
            this.ucExplorer1.TabIndex = 10;
            // 
            // ucie2
            // 
            this.ucie2.BackColor = System.Drawing.Color.Transparent;
            this.ucie2.CheckedAll = false;
            this.ucie2.Location = new System.Drawing.Point(0, 223);
            this.ucie2.Name = "ucie2";
            this.ucie2.Size = new System.Drawing.Size(262, 216);
            this.ucie2.TabIndex = 6;
            // 
            // tabPageApps
            // 
            this.tabPageApps.Controls.Add(this.panelNonWindowsApps);
            this.tabPageApps.Location = new System.Drawing.Point(4, 34);
            this.tabPageApps.Name = "tabPageApps";
            this.tabPageApps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApps.Size = new System.Drawing.Size(268, 1113);
            this.tabPageApps.TabIndex = 1;
            this.tabPageApps.Text = "Applications";
            this.tabPageApps.UseVisualStyleBackColor = true;
            // 
            // tabControlCleaner
            // 
            this.tabControlCleaner.Controls.Add(this.tabPageWin);
            this.tabControlCleaner.Controls.Add(this.tabPageApps);
            this.tabControlCleaner.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlCleaner.ItemSize = new System.Drawing.Size(80, 30);
            this.tabControlCleaner.Location = new System.Drawing.Point(0, 0);
            this.tabControlCleaner.Name = "tabControlCleaner";
            this.tabControlCleaner.SelectedIndex = 0;
            this.tabControlCleaner.Size = new System.Drawing.Size(276, 1151);
            this.tabControlCleaner.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlCleaner.TabIndex = 1;
            // 
            // panelNonWindowsApps
            // 
            this.panelNonWindowsApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNonWindowsApps.Location = new System.Drawing.Point(3, 3);
            this.panelNonWindowsApps.Name = "panelNonWindowsApps";
            this.panelNonWindowsApps.Size = new System.Drawing.Size(262, 1107);
            this.panelNonWindowsApps.TabIndex = 0;
            // 
            // UCCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlCleaner);
            this.Name = "UCCleaner";
            this.Size = new System.Drawing.Size(276, 1124);
            this.tabPageWin.ResumeLayout(false);
            this.tabPageApps.ResumeLayout(false);
            this.tabControlCleaner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCEdge ucEdge1;
        private System.Windows.Forms.TabPage tabPageWin;
        private Cleaner.Windows.UCSystem ucSystem1;
        private Cleaner.Windows.UCExplorer ucExplorer1;
        private UCIE ucie2;
        private System.Windows.Forms.TabPage tabPageApps;
        private System.Windows.Forms.TabControl tabControlCleaner;
        private Cleaner.Windows.UCAdvanced ucAdvanced1;
        private System.Windows.Forms.Panel panelNonWindowsApps;
    }
}
