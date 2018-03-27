namespace PCCleaner.Controls
{
    partial class UCIE
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
            this.chkListEdge = new System.Windows.Forms.CheckedListBox();
            this.EdgeHeading = new PCCleaner.Controls.UCImageHeading();
            this.SuspendLayout();
            // 
            // chkListEdge
            // 
            this.chkListEdge.BackColor = System.Drawing.SystemColors.Control;
            this.chkListEdge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListEdge.CheckOnClick = true;
            this.chkListEdge.FormattingEnabled = true;
            this.chkListEdge.Items.AddRange(new object[] {
            "Internet Cache",
            "Internet History",
            "Cookies",
            "Download History",
            "Last Download Location",
            "Session",
            "Set Aside Tabs",
            "Recently Typed Urls",
            "Saved Form Information",
            "Saved Passwords"});
            this.chkListEdge.Location = new System.Drawing.Point(33, 32);
            this.chkListEdge.Name = "chkListEdge";
            this.chkListEdge.Size = new System.Drawing.Size(229, 187);
            this.chkListEdge.TabIndex = 4;
            // 
            // EdgeHeading
            // 
            this.EdgeHeading.Location = new System.Drawing.Point(3, 5);
            this.EdgeHeading.Name = "EdgeHeading";
            this.EdgeHeading.Size = new System.Drawing.Size(150, 22);
            this.EdgeHeading.TabIndex = 5;
            // 
            // UCIE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.EdgeHeading);
            this.Controls.Add(this.chkListEdge);
            this.Name = "UCIE";
            this.Size = new System.Drawing.Size(262, 243);
            this.ResumeLayout(false);

        }

        #endregion

        private UCImageHeading EdgeHeading;
        private System.Windows.Forms.CheckedListBox chkListEdge;
    }
}
