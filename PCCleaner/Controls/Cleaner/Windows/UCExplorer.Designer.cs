namespace PCCleaner.Controls.Cleaner.Windows
{
    partial class UCExplorer
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
            this.EdgeHeading = new PCCleaner.Controls.UCImageHeading();
            this.chkListEdge = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // EdgeHeading
            // 
            this.EdgeHeading.Location = new System.Drawing.Point(3, 9);
            this.EdgeHeading.Name = "EdgeHeading";
            this.EdgeHeading.Size = new System.Drawing.Size(150, 22);
            this.EdgeHeading.TabIndex = 7;
            // 
            // chkListEdge
            // 
            this.chkListEdge.BackColor = System.Drawing.SystemColors.Control;
            this.chkListEdge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListEdge.CheckOnClick = true;
            this.chkListEdge.FormattingEnabled = true;
            this.chkListEdge.Items.AddRange(new object[] {
            "Recent Documents",
            "Run (in start menu)",
            "Other Explorer MRUs",
            "Thumbnail Cache",
            "Taskbar Jump Lists",
            "Network Passwords"});
            this.chkListEdge.Location = new System.Drawing.Point(31, 36);
            this.chkListEdge.Name = "chkListEdge";
            this.chkListEdge.Size = new System.Drawing.Size(231, 119);
            this.chkListEdge.TabIndex = 6;
            // 
            // UCExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EdgeHeading);
            this.Controls.Add(this.chkListEdge);
            this.Name = "UCExplorer";
            this.Size = new System.Drawing.Size(262, 162);
            this.ResumeLayout(false);

        }

        #endregion

        private UCImageHeading EdgeHeading;
        private System.Windows.Forms.CheckedListBox chkListEdge;
    }
}
