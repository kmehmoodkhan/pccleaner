namespace PCCleaner.Controls.Common
{
    partial class UCResult
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelTimeTaken = new System.Windows.Forms.Label();
            this.labelResultHeading = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.lineTop = new System.Windows.Forms.Label();
            this.lineBottom = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.dataGridViewOverall = new System.Windows.Forms.DataGridView();
            this.col_Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col_App = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchFeature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemViewDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.AreaIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripDetail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverall)).BeginInit();
            this.contextMenuStripResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.labelTimeTaken);
            this.panelStatus.Controls.Add(this.labelResultHeading);
            this.panelStatus.Controls.Add(this.pictureBoxResult);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(614, 44);
            this.panelStatus.TabIndex = 0;
            // 
            // labelTimeTaken
            // 
            this.labelTimeTaken.AutoSize = true;
            this.labelTimeTaken.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeTaken.Location = new System.Drawing.Point(211, 12);
            this.labelTimeTaken.Name = "labelTimeTaken";
            this.labelTimeTaken.Size = new System.Drawing.Size(88, 16);
            this.labelTimeTaken.TabIndex = 2;
            this.labelTimeTaken.Text = "[Time Taken]";
            // 
            // labelResultHeading
            // 
            this.labelResultHeading.AutoSize = true;
            this.labelResultHeading.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultHeading.Location = new System.Drawing.Point(39, 10);
            this.labelResultHeading.Name = "labelResultHeading";
            this.labelResultHeading.Size = new System.Drawing.Size(145, 16);
            this.labelResultHeading.TabIndex = 1;
            this.labelResultHeading.Text = "Analysis Complete -";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Image = global::PCCleaner.Properties.Resources.Tick;
            this.pictureBoxResult.Location = new System.Drawing.Point(12, 10);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxResult.TabIndex = 0;
            this.pictureBoxResult.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.lineTop);
            this.panel1.Controls.Add(this.lineBottom);
            this.panel1.Controls.Add(this.labelNotes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 79);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 22);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(188, 34);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "View Summary Results";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // lineTop
            // 
            this.lineTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineTop.Location = new System.Drawing.Point(2, 5);
            this.lineTop.Name = "lineTop";
            this.lineTop.Size = new System.Drawing.Size(498, 2);
            this.lineTop.TabIndex = 9;
            // 
            // lineBottom
            // 
            this.lineBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineBottom.Location = new System.Drawing.Point(2, 57);
            this.lineBottom.Name = "lineBottom";
            this.lineBottom.Size = new System.Drawing.Size(498, 2);
            this.lineBottom.TabIndex = 8;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(11, 25);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(476, 16);
            this.labelNotes.TabIndex = 6;
            this.labelNotes.Text = "Detail of files to be deleted ( Note: No files have been deleted yet )";
            this.labelNotes.Visible = false;
            // 
            // dataGridViewOverall
            // 
            this.dataGridViewOverall.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dataGridViewOverall.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOverall.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOverall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOverall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOverall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Icon,
            this.Col_App,
            this.Col_Area,
            this.Col_FileSize,
            this.Col_Files,
            this.SearchArea,
            this.SearchFeature});
            this.dataGridViewOverall.ContextMenuStrip = this.contextMenuStripResult;
            this.dataGridViewOverall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOverall.Location = new System.Drawing.Point(0, 123);
            this.dataGridViewOverall.MultiSelect = false;
            this.dataGridViewOverall.Name = "dataGridViewOverall";
            this.dataGridViewOverall.RowTemplate.Height = 24;
            this.dataGridViewOverall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOverall.Size = new System.Drawing.Size(614, 262);
            this.dataGridViewOverall.TabIndex = 2;
            this.dataGridViewOverall.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOverall_CellMouseEnter);
            // 
            // col_Icon
            // 
            this.col_Icon.DataPropertyName = "Icon";
            this.col_Icon.HeaderText = "";
            this.col_Icon.Name = "col_Icon";
            this.col_Icon.Width = 30;
            // 
            // Col_App
            // 
            this.Col_App.DataPropertyName = "SearchAreaTitle";
            this.Col_App.HeaderText = "";
            this.Col_App.Name = "Col_App";
            this.Col_App.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_App.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Area
            // 
            this.Col_Area.DataPropertyName = "FeatureName";
            this.Col_Area.HeaderText = "";
            this.Col_Area.Name = "Col_Area";
            this.Col_Area.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Area.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_FileSize
            // 
            this.Col_FileSize.DataPropertyName = "FilesSize";
            this.Col_FileSize.HeaderText = "";
            this.Col_FileSize.Name = "Col_FileSize";
            // 
            // Col_Files
            // 
            this.Col_Files.DataPropertyName = "TotalFiles";
            this.Col_Files.HeaderText = "";
            this.Col_Files.Name = "Col_Files";
            // 
            // SearchArea
            // 
            this.SearchArea.DataPropertyName = "SearchArea";
            this.SearchArea.HeaderText = "SearchArea";
            this.SearchArea.Name = "SearchArea";
            this.SearchArea.Visible = false;
            // 
            // SearchFeature
            // 
            this.SearchFeature.DataPropertyName = "FeatureName";
            this.SearchFeature.HeaderText = "SearchFeature";
            this.SearchFeature.Name = "SearchFeature";
            this.SearchFeature.Visible = false;
            // 
            // contextMenuStripResult
            // 
            this.contextMenuStripResult.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemViewDetail,
            this.toolStripMenuItemSaveTo});
            this.contextMenuStripResult.Name = "contextMenuStripResult";
            this.contextMenuStripResult.Size = new System.Drawing.Size(216, 52);
            // 
            // toolStripMenuItemViewDetail
            // 
            this.toolStripMenuItemViewDetail.CheckOnClick = true;
            this.toolStripMenuItemViewDetail.Name = "toolStripMenuItemViewDetail";
            this.toolStripMenuItemViewDetail.Size = new System.Drawing.Size(215, 24);
            this.toolStripMenuItemViewDetail.Text = "View detailed results";
            this.toolStripMenuItemViewDetail.Click += new System.EventHandler(this.toolStripMenuItemViewDetail_Click);
            // 
            // toolStripMenuItemSaveTo
            // 
            this.toolStripMenuItemSaveTo.Name = "toolStripMenuItemSaveTo";
            this.toolStripMenuItemSaveTo.Size = new System.Drawing.Size(215, 24);
            this.toolStripMenuItemSaveTo.Text = "Save to text file";
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AreaIcon,
            this.col_Description,
            this.Col_Size});
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 123);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 24;
            this.dataGridViewDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetail.Size = new System.Drawing.Size(614, 262);
            this.dataGridViewDetail.TabIndex = 3;
            // 
            // AreaIcon
            // 
            this.AreaIcon.DataPropertyName = "Icon";
            this.AreaIcon.HeaderText = "";
            this.AreaIcon.Name = "AreaIcon";
            this.AreaIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AreaIcon.Width = 50;
            // 
            // col_Description
            // 
            this.col_Description.DataPropertyName = "FilePath";
            this.col_Description.HeaderText = "Description";
            this.col_Description.Name = "col_Description";
            this.col_Description.Width = 1080;
            // 
            // Col_Size
            // 
            this.Col_Size.DataPropertyName = "FileSize";
            this.Col_Size.HeaderText = "Size";
            this.Col_Size.Name = "Col_Size";
            // 
            // contextMenuStripDetail
            // 
            this.contextMenuStripDetail.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDetail.Name = "contextMenuStripDetail";
            this.contextMenuStripDetail.Size = new System.Drawing.Size(61, 4);
            // 
            // UCResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDetail);
            this.Controls.Add(this.dataGridViewOverall);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelStatus);
            this.Name = "UCResult";
            this.Size = new System.Drawing.Size(614, 385);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverall)).EndInit();
            this.contextMenuStripResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label labelResultHeading;
        private System.Windows.Forms.Label labelTimeTaken;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewOverall;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripResult;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewDetail;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveTo;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label lineBottom;
        private System.Windows.Forms.Label lineTop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDetail;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridViewImageColumn col_Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_App;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Files;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchFeature;
        private System.Windows.Forms.DataGridViewImageColumn AreaIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Size;
    }
}
