namespace PCCleaner.Controls.Common
{
    partial class UCAppsList
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
            this.chkListEdge.Location = new System.Drawing.Point(30, 48);
            this.chkListEdge.Name = "chkListEdge";
            this.chkListEdge.Size = new System.Drawing.Size(231, 187);
            this.chkListEdge.TabIndex = 8;
            // 
            // EdgeHeading
            // 
            this.EdgeHeading.BackColor = System.Drawing.SystemColors.Control;
            this.EdgeHeading.Location = new System.Drawing.Point(2, 20);
            this.EdgeHeading.Name = "EdgeHeading";
            this.EdgeHeading.Size = new System.Drawing.Size(150, 22);
            this.EdgeHeading.TabIndex = 9;
            // 
            // UCAppsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.EdgeHeading);
            this.Controls.Add(this.chkListEdge);
            this.Name = "UCAppsList";
            this.Size = new System.Drawing.Size(262, 254);
            this.ResumeLayout(false);

        }

        #endregion

        private UCImageHeading EdgeHeading;
        private System.Windows.Forms.CheckedListBox chkListEdge;
    }
}
