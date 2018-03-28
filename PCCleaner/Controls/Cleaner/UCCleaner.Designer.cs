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
            this.tabPageWin = new System.Windows.Forms.TabPage();
            this.panelWindowApps = new System.Windows.Forms.Panel();
            this.ucAdvanced1 = new PCCleaner.Controls.Cleaner.Windows.UCAdvanced();
            this.ucSystem1 = new PCCleaner.Controls.Cleaner.Windows.UCSystem();
            this.ucExplorer1 = new PCCleaner.Controls.Cleaner.Windows.UCExplorer();
            this.ucEdge1 = new PCCleaner.Controls.UCEdge();
            this.ucie2 = new PCCleaner.Controls.UCIE();
            this.tabPageApps = new System.Windows.Forms.TabPage();
            this.panelNonWindowsApps = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlCleaner = new System.Windows.Forms.TabControl();
            this.tabPageWin.SuspendLayout();
            this.panelWindowApps.SuspendLayout();
            this.tabPageApps.SuspendLayout();
            this.tabControlCleaner.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageWin
            // 
            this.tabPageWin.AutoScroll = true;
            this.tabPageWin.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageWin.Controls.Add(this.panelWindowApps);
            this.tabPageWin.Location = new System.Drawing.Point(4, 34);
            this.tabPageWin.Name = "tabPageWin";
            this.tabPageWin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWin.Size = new System.Drawing.Size(268, 1113);
            this.tabPageWin.TabIndex = 0;
            this.tabPageWin.Text = "Windows";
            // 
            // panelWindowApps
            // 
            this.panelWindowApps.Controls.Add(this.ucAdvanced1);
            this.panelWindowApps.Controls.Add(this.ucSystem1);
            this.panelWindowApps.Controls.Add(this.ucExplorer1);
            this.panelWindowApps.Controls.Add(this.ucEdge1);
            this.panelWindowApps.Controls.Add(this.ucie2);
            this.panelWindowApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindowApps.Location = new System.Drawing.Point(3, 3);
            this.panelWindowApps.Name = "panelWindowApps";
            this.panelWindowApps.Size = new System.Drawing.Size(262, 1107);
            this.panelWindowApps.TabIndex = 0;
            // 
            // ucAdvanced1
            // 
            this.ucAdvanced1.CheckedAll = false;
            this.ucAdvanced1.Location = new System.Drawing.Point(-1, 853);
            this.ucAdvanced1.Name = "ucAdvanced1";
            this.ucAdvanced1.Size = new System.Drawing.Size(262, 240);
            this.ucAdvanced1.TabIndex = 18;
            // 
            // ucSystem1
            // 
            this.ucSystem1.CheckedAll = false;
            this.ucSystem1.Location = new System.Drawing.Point(-1, 607);
            this.ucSystem1.Name = "ucSystem1";
            this.ucSystem1.Size = new System.Drawing.Size(262, 240);
            this.ucSystem1.TabIndex = 17;
            // 
            // ucExplorer1
            // 
            this.ucExplorer1.BackColor = System.Drawing.SystemColors.Control;
            this.ucExplorer1.CheckedAll = false;
            this.ucExplorer1.Location = new System.Drawing.Point(2, 454);
            this.ucExplorer1.Name = "ucExplorer1";
            this.ucExplorer1.Size = new System.Drawing.Size(262, 151);
            this.ucExplorer1.TabIndex = 16;
            // 
            // ucEdge1
            // 
            this.ucEdge1.CheckedAll = false;
            this.ucEdge1.Location = new System.Drawing.Point(-1, 14);
            this.ucEdge1.Name = "ucEdge1";
            this.ucEdge1.Size = new System.Drawing.Size(262, 224);
            this.ucEdge1.TabIndex = 15;
            // 
            // ucie2
            // 
            this.ucie2.BackColor = System.Drawing.Color.Transparent;
            this.ucie2.CheckedAll = false;
            this.ucie2.Location = new System.Drawing.Point(-1, 237);
            this.ucie2.Name = "ucie2";
            this.ucie2.Size = new System.Drawing.Size(262, 216);
            this.ucie2.TabIndex = 14;
            this.ucie2.Visible = false;
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
            // panelNonWindowsApps
            // 
            this.panelNonWindowsApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNonWindowsApps.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelNonWindowsApps.Location = new System.Drawing.Point(3, 3);
            this.panelNonWindowsApps.Name = "panelNonWindowsApps";
            this.panelNonWindowsApps.Size = new System.Drawing.Size(262, 1107);
            this.panelNonWindowsApps.TabIndex = 0;
            this.panelNonWindowsApps.WrapContents = false;
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
            // UCCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlCleaner);
            this.Name = "UCCleaner";
            this.Size = new System.Drawing.Size(276, 1124);
            this.tabPageWin.ResumeLayout(false);
            this.panelWindowApps.ResumeLayout(false);
            this.tabPageApps.ResumeLayout(false);
            this.tabControlCleaner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageWin;
        private System.Windows.Forms.TabPage tabPageApps;
        private System.Windows.Forms.TabControl tabControlCleaner;
        private System.Windows.Forms.Panel panelWindowApps;
        private Cleaner.Windows.UCAdvanced ucAdvanced1;
        private Cleaner.Windows.UCSystem ucSystem1;
        private Cleaner.Windows.UCExplorer ucExplorer1;
        private UCEdge ucEdge1;
        private UCIE ucie2;
        private System.Windows.Forms.FlowLayoutPanel panelNonWindowsApps;
    }
}
