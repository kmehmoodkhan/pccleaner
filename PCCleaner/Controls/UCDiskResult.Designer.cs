namespace PCCleaner.Controls
{
    partial class UCDiskResult
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.Col_Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ModifiedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSpaceCategories = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPercentageBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBackButton = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMain.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.panelSpaceCategories.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelBackButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelSpaceCategories);
            this.panelMain.Controls.Add(this.panelPercentageBar);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panelBackButton);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(10);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(837, 872);
            this.panelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridViewResult);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGrid.Location = new System.Drawing.Point(10, 547);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelGrid.Size = new System.Drawing.Size(817, 262);
            this.panelGrid.TabIndex = 8;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Select,
            this.Col_Name,
            this.Col_Path,
            this.Col_Type,
            this.Col_Size,
            this.Col_Category,
            this.Col_ModifiedTime});
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 15);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(817, 245);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // Col_Select
            // 
            this.Col_Select.HeaderText = "";
            this.Col_Select.Name = "Col_Select";
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "FileName";
            this.Col_Name.FillWeight = 150F;
            this.Col_Name.HeaderText = "Name";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Path
            // 
            this.Col_Path.DataPropertyName = "FilePath";
            this.Col_Path.FillWeight = 500F;
            this.Col_Path.HeaderText = "Path";
            this.Col_Path.Name = "Col_Path";
            this.Col_Path.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Path.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Type
            // 
            this.Col_Type.DataPropertyName = "FileType";
            this.Col_Type.HeaderText = "Type";
            this.Col_Type.Name = "Col_Type";
            this.Col_Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Size
            // 
            this.Col_Size.DataPropertyName = "FileSize";
            this.Col_Size.HeaderText = "Size";
            this.Col_Size.Name = "Col_Size";
            this.Col_Size.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Category
            // 
            this.Col_Category.DataPropertyName = "Category";
            this.Col_Category.HeaderText = "Category";
            this.Col_Category.Name = "Col_Category";
            this.Col_Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_ModifiedTime
            // 
            this.Col_ModifiedTime.DataPropertyName = "ModifiedTime";
            this.Col_ModifiedTime.HeaderText = "Modified Time";
            this.Col_ModifiedTime.Name = "Col_ModifiedTime";
            // 
            // panelSpaceCategories
            // 
            this.panelSpaceCategories.Controls.Add(this.panel4);
            this.panelSpaceCategories.Controls.Add(this.panel3);
            this.panelSpaceCategories.Controls.Add(this.panel2);
            this.panelSpaceCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpaceCategories.Location = new System.Drawing.Point(10, 210);
            this.panelSpaceCategories.Name = "panelSpaceCategories";
            this.panelSpaceCategories.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelSpaceCategories.Size = new System.Drawing.Size(817, 337);
            this.panelSpaceCategories.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(817, 86);
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 2);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Space";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 86);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "All Categories";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 86);
            this.panel2.TabIndex = 7;
            // 
            // panelPercentageBar
            // 
            this.panelPercentageBar.BackColor = System.Drawing.Color.White;
            this.panelPercentageBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPercentageBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPercentageBar.Location = new System.Drawing.Point(10, 124);
            this.panelPercentageBar.Name = "panelPercentageBar";
            this.panelPercentageBar.Size = new System.Drawing.Size(817, 86);
            this.panelPercentageBar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.label1.Size = new System.Drawing.Size(95, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Categories";
            // 
            // panelBackButton
            // 
            this.panelBackButton.Controls.Add(this.buttonBack);
            this.panelBackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBackButton.Location = new System.Drawing.Point(10, 10);
            this.panelBackButton.Name = "panelBackButton";
            this.panelBackButton.Size = new System.Drawing.Size(817, 57);
            this.panelBackButton.TabIndex = 4;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(110, 39);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // UCDiskResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "UCDiskResult";
            this.Size = new System.Drawing.Size(837, 872);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.panelSpaceCategories.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelBackButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBackButton;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPercentageBar;
        private System.Windows.Forms.Panel panelSpaceCategories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ModifiedTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
