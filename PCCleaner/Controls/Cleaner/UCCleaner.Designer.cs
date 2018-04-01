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
            this.tabPageApps = new System.Windows.Forms.TabPage();
            this.panelNonWindowsApps = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlCleaner = new System.Windows.Forms.TabControl();
            this.panelWindowApps = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageWin.SuspendLayout();
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
            this.panelNonWindowsApps.BackColor = System.Drawing.SystemColors.Control;
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
            // panelWindowApps
            // 
            this.panelWindowApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindowApps.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelWindowApps.Location = new System.Drawing.Point(3, 3);
            this.panelWindowApps.Name = "panelWindowApps";
            this.panelWindowApps.Size = new System.Drawing.Size(262, 1107);
            this.panelWindowApps.TabIndex = 0;
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
        private System.Windows.Forms.TabPage tabPageWin;
        private System.Windows.Forms.TabPage tabPageApps;
        private System.Windows.Forms.TabControl tabControlCleaner;
        private System.Windows.Forms.FlowLayoutPanel panelNonWindowsApps;
        private System.Windows.Forms.FlowLayoutPanel panelWindowApps;
    }
}
