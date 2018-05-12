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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewSummary = new System.Windows.Forms.DataGridView();
            this.Col_FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TotalFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAllCategories = new System.Windows.Forms.Label();
            this.panelBackButton = new System.Windows.Forms.Panel();
            this.panelLoader = new System.Windows.Forms.Panel();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.pictureBoxLoader = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMain.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.panelSpaceCategories.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummary)).BeginInit();
            this.panelBackButton.SuspendLayout();
            this.panelLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelSpaceCategories);
            this.panelMain.Controls.Add(this.labelAllCategories);
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
            this.panelGrid.Location = new System.Drawing.Point(10, 461);
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
            this.panelSpaceCategories.Controls.Add(this.panel2);
            this.panelSpaceCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpaceCategories.Location = new System.Drawing.Point(10, 124);
            this.panelSpaceCategories.Name = "panelSpaceCategories";
            this.panelSpaceCategories.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelSpaceCategories.Size = new System.Drawing.Size(817, 337);
            this.panelSpaceCategories.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridViewSummary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 316);
            this.panel2.TabIndex = 7;
            // 
            // dataGridViewSummary
            // 
            this.dataGridViewSummary.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_FileType,
            this.Col_TotalFiles,
            this.Col_FileSize});
            this.dataGridViewSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSummary.GridColor = System.Drawing.Color.White;
            this.dataGridViewSummary.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSummary.Name = "dataGridViewSummary";
            this.dataGridViewSummary.RowTemplate.Height = 24;
            this.dataGridViewSummary.Size = new System.Drawing.Size(815, 314);
            this.dataGridViewSummary.TabIndex = 0;
            // 
            // Col_FileType
            // 
            this.Col_FileType.DataPropertyName = "FileType";
            this.Col_FileType.HeaderText = "File Type";
            this.Col_FileType.Name = "Col_FileType";
            this.Col_FileType.Width = 200;
            // 
            // Col_TotalFiles
            // 
            this.Col_TotalFiles.DataPropertyName = "FilesCount";
            this.Col_TotalFiles.HeaderText = "No of Files";
            this.Col_TotalFiles.Name = "Col_TotalFiles";
            this.Col_TotalFiles.Width = 150;
            // 
            // Col_FileSize
            // 
            this.Col_FileSize.DataPropertyName = "FileSize";
            this.Col_FileSize.HeaderText = "File Size";
            this.Col_FileSize.Name = "Col_FileSize";
            this.Col_FileSize.Width = 150;
            // 
            // labelAllCategories
            // 
            this.labelAllCategories.AutoSize = true;
            this.labelAllCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAllCategories.Location = new System.Drawing.Point(10, 67);
            this.labelAllCategories.Name = "labelAllCategories";
            this.labelAllCategories.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.labelAllCategories.Size = new System.Drawing.Size(95, 57);
            this.labelAllCategories.TabIndex = 5;
            this.labelAllCategories.Text = "All Categories";
            // 
            // panelBackButton
            // 
            this.panelBackButton.Controls.Add(this.panelLoader);
            this.panelBackButton.Controls.Add(this.buttonBack);
            this.panelBackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBackButton.Location = new System.Drawing.Point(10, 10);
            this.panelBackButton.Name = "panelBackButton";
            this.panelBackButton.Size = new System.Drawing.Size(817, 57);
            this.panelBackButton.TabIndex = 4;
            // 
            // panelLoader
            // 
            this.panelLoader.Controls.Add(this.labelProgressBar);
            this.panelLoader.Controls.Add(this.pictureBoxLoader);
            this.panelLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoader.Location = new System.Drawing.Point(0, 0);
            this.panelLoader.Name = "panelLoader";
            this.panelLoader.Size = new System.Drawing.Size(817, 57);
            this.panelLoader.TabIndex = 1;
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar.Location = new System.Drawing.Point(42, 0);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Padding = new System.Windows.Forms.Padding(0, 17, 0, 0);
            this.labelProgressBar.Size = new System.Drawing.Size(154, 37);
            this.labelProgressBar.TabIndex = 4;
            this.labelProgressBar.Text = "Loading file system";
            this.labelProgressBar.Visible = false;
            // 
            // pictureBoxLoader
            // 
            this.pictureBoxLoader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLoader.Image = global::PCCleaner.Properties.Resources.Loader;
            this.pictureBoxLoader.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLoader.MinimumSize = new System.Drawing.Size(24, 24);
            this.pictureBoxLoader.Name = "pictureBoxLoader";
            this.pictureBoxLoader.Size = new System.Drawing.Size(42, 57);
            this.pictureBoxLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoader.TabIndex = 3;
            this.pictureBoxLoader.TabStop = false;
            this.pictureBoxLoader.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(110, 39);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummary)).EndInit();
            this.panelBackButton.ResumeLayout(false);
            this.panelLoader.ResumeLayout(false);
            this.panelLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelBackButton;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ModifiedTime;
        private System.Windows.Forms.Panel panelSpaceCategories;
        private System.Windows.Forms.Panel panelLoader;
        private System.Windows.Forms.Label labelProgressBar;
        private System.Windows.Forms.PictureBox pictureBoxLoader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAllCategories;
        private System.Windows.Forms.DataGridView dataGridViewSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TotalFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FileSize;
    }
}
