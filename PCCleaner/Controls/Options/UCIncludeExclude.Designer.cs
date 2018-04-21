namespace PCCleaner.Controls.Options
{
    partial class UCIncludeExclude
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxSelections = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTools = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUninstall = new System.Windows.Forms.Button();
            this.buttonStartup = new System.Windows.Forms.Button();
            this.buttonPlugins = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanelTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBoxSelections);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 546);
            this.panel1.TabIndex = 0;
            // 
            // listBoxSelections
            // 
            this.listBoxSelections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSelections.FormattingEnabled = true;
            this.listBoxSelections.ItemHeight = 16;
            this.listBoxSelections.Location = new System.Drawing.Point(0, 27);
            this.listBoxSelections.Name = "listBoxSelections";
            this.listBoxSelections.Size = new System.Drawing.Size(704, 517);
            this.listBoxSelections.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(268, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom Files to delete and Folders empty";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanelTools);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(509, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 546);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanelTools
            // 
            this.flowLayoutPanelTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelTools.Controls.Add(this.buttonUninstall);
            this.flowLayoutPanelTools.Controls.Add(this.buttonStartup);
            this.flowLayoutPanelTools.Controls.Add(this.buttonPlugins);
            this.flowLayoutPanelTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelTools.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTools.Name = "flowLayoutPanelTools";
            this.flowLayoutPanelTools.Size = new System.Drawing.Size(196, 546);
            this.flowLayoutPanelTools.TabIndex = 1;
            // 
            // buttonUninstall
            // 
            this.buttonUninstall.Location = new System.Drawing.Point(3, 3);
            this.buttonUninstall.Name = "buttonUninstall";
            this.buttonUninstall.Size = new System.Drawing.Size(205, 45);
            this.buttonUninstall.TabIndex = 0;
            this.buttonUninstall.Text = "Uninstall";
            this.buttonUninstall.UseVisualStyleBackColor = true;
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
            // buttonPlugins
            // 
            this.buttonPlugins.Location = new System.Drawing.Point(3, 105);
            this.buttonPlugins.Name = "buttonPlugins";
            this.buttonPlugins.Size = new System.Drawing.Size(205, 45);
            this.buttonPlugins.TabIndex = 2;
            this.buttonPlugins.Text = "Plugins";
            this.buttonPlugins.UseVisualStyleBackColor = true;
            // 
            // UCIncludeExclude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCIncludeExclude";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(712, 552);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanelTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTools;
        private System.Windows.Forms.Button buttonUninstall;
        private System.Windows.Forms.Button buttonStartup;
        private System.Windows.Forms.Button buttonPlugins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSelections;
    }
}
