namespace PCCleaner.Controls
{
    partial class UCImageHeading
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
            this.lblEdge = new System.Windows.Forms.Label();
            this.pcEdge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEdge
            // 
            this.lblEdge.AutoSize = true;
            this.lblEdge.Location = new System.Drawing.Point(25, 0);
            this.lblEdge.Name = "lblEdge";
            this.lblEdge.Size = new System.Drawing.Size(0, 17);
            this.lblEdge.TabIndex = 4;
            // 
            // pcEdge
            // 
            this.pcEdge.BackColor = System.Drawing.SystemColors.Control;
            this.pcEdge.Location = new System.Drawing.Point(-2, -3);
            this.pcEdge.Name = "pcEdge";
            this.pcEdge.Size = new System.Drawing.Size(30, 30);
            this.pcEdge.TabIndex = 3;
            this.pcEdge.TabStop = false;
            this.pcEdge.Click += new System.EventHandler(this.pcEdge_Click);
            // 
            // UCImageHeading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEdge);
            this.Controls.Add(this.pcEdge);
            this.Name = "UCImageHeading";
            this.Size = new System.Drawing.Size(144, 22);
            ((System.ComponentModel.ISupportInitialize)(this.pcEdge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdge;
        private System.Windows.Forms.PictureBox pcEdge;
    }
}
