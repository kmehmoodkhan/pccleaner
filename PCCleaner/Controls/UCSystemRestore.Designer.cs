namespace PCCleaner.Controls
{
    partial class UCSystemRestore
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
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.PanelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewBackups = new System.Windows.Forms.DataGridView();
            this.Col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackups)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Location = new System.Drawing.Point(0, 357);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Padding = new System.Windows.Forms.Padding(10);
            this.panelBottomBar.Size = new System.Drawing.Size(913, 97);
            this.panelBottomBar.TabIndex = 0;
            // 
            // PanelGrid
            // 
            this.PanelGrid.Controls.Add(this.dataGridViewBackups);
            this.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGrid.Location = new System.Drawing.Point(0, 0);
            this.PanelGrid.Name = "PanelGrid";
            this.PanelGrid.Size = new System.Drawing.Size(913, 357);
            this.PanelGrid.TabIndex = 1;
            // 
            // dataGridViewBackups
            // 
            this.dataGridViewBackups.AllowUserToDeleteRows = false;
            this.dataGridViewBackups.AllowUserToResizeRows = false;
            this.dataGridViewBackups.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBackups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Date,
            this.Col_Description});
            this.dataGridViewBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBackups.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBackups.Margin = new System.Windows.Forms.Padding(15);
            this.dataGridViewBackups.Name = "dataGridViewBackups";
            this.dataGridViewBackups.RowTemplate.Height = 24;
            this.dataGridViewBackups.ShowRowErrors = false;
            this.dataGridViewBackups.Size = new System.Drawing.Size(913, 357);
            this.dataGridViewBackups.TabIndex = 0;
            // 
            // Col_Date
            // 
            this.Col_Date.DataPropertyName = "CreatedOn";
            this.Col_Date.HeaderText = "Date and Time";
            this.Col_Date.Name = "Col_Date";
            this.Col_Date.Width = 150;
            // 
            // Col_Description
            // 
            this.Col_Description.DataPropertyName = "Description";
            this.Col_Description.HeaderText = "Description";
            this.Col_Description.Name = "Col_Description";
            this.Col_Description.Width = 300;
            // 
            // UCSystemRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelGrid);
            this.Controls.Add(this.panelBottomBar);
            this.Name = "UCSystemRestore";
            this.Size = new System.Drawing.Size(913, 454);
            this.PanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Panel PanelGrid;
        private System.Windows.Forms.DataGridView dataGridViewBackups;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Description;
    }
}
