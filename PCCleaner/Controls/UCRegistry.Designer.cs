namespace PCCleaner.Controls
{
    partial class UCRegistry
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
            this.flowLayoutPanelRegistry = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelRegistry
            // 
            this.flowLayoutPanelRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRegistry.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRegistry.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelRegistry.Name = "flowLayoutPanelRegistry";
            this.flowLayoutPanelRegistry.Size = new System.Drawing.Size(264, 524);
            this.flowLayoutPanelRegistry.TabIndex = 0;
            // 
            // UCRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelRegistry);
            this.Name = "UCRegistry";
            this.Size = new System.Drawing.Size(264, 524);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRegistry;
    }
}
