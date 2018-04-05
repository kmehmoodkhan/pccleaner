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
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimeTaken = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDetails = new System.Windows.Forms.Label();
            this.dataGridViewOverall = new System.Windows.Forms.DataGridView();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemViewDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.col_Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col_App = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.contextMenuStripResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.labelTimeTaken);
            this.panelStatus.Controls.Add(this.label1);
            this.panelStatus.Controls.Add(this.pictureBoxResult);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(614, 58);
            this.panelStatus.TabIndex = 0;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Image = global::PCCleaner.Properties.Resources.Tick;
            this.pictureBoxResult.Location = new System.Drawing.Point(12, 19);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxResult.TabIndex = 0;
            this.pictureBoxResult.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Analysis Complete";
            // 
            // labelTimeTaken
            // 
            this.labelTimeTaken.AutoSize = true;
            this.labelTimeTaken.Location = new System.Drawing.Point(199, 21);
            this.labelTimeTaken.Name = "labelTimeTaken";
            this.labelTimeTaken.Size = new System.Drawing.Size(91, 17);
            this.labelTimeTaken.TabIndex = 2;
            this.labelTimeTaken.Text = "[Time Taken]";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 58);
            this.panel1.TabIndex = 1;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(9, 21);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(74, 19);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Text = "[Details]";
            // 
            // dataGridViewOverall
            // 
            this.dataGridViewOverall.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dataGridViewOverall.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOverall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOverall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOverall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Icon,
            this.Col_App,
            this.Col_Area,
            this.Col_FileSize,
            this.Col_Files});
            this.dataGridViewOverall.ContextMenuStrip = this.contextMenuStripResult;
            this.dataGridViewOverall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOverall.Location = new System.Drawing.Point(0, 116);
            this.dataGridViewOverall.Name = "dataGridViewOverall";
            this.dataGridViewOverall.RowTemplate.Height = 24;
            this.dataGridViewOverall.Size = new System.Drawing.Size(614, 269);
            this.dataGridViewOverall.TabIndex = 2;
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Description,
            this.Col_Size});
            this.dataGridViewDetail.Location = new System.Drawing.Point(3, 151);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 24;
            this.dataGridViewDetail.Size = new System.Drawing.Size(614, 269);
            this.dataGridViewDetail.TabIndex = 3;
            // 
            // col_Description
            // 
            this.col_Description.HeaderText = "";
            this.col_Description.Name = "col_Description";
            // 
            // Col_Size
            // 
            this.Col_Size.HeaderText = "";
            this.Col_Size.Name = "Col_Size";
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
            this.toolStripMenuItemViewDetail.Name = "toolStripMenuItemViewDetail";
            this.toolStripMenuItemViewDetail.Size = new System.Drawing.Size(215, 24);
            this.toolStripMenuItemViewDetail.Text = "View detailed results";
            // 
            // toolStripMenuItemSaveTo
            // 
            this.toolStripMenuItemSaveTo.Name = "toolStripMenuItemSaveTo";
            this.toolStripMenuItemSaveTo.Size = new System.Drawing.Size(215, 24);
            this.toolStripMenuItemSaveTo.Text = "Save to text file";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.contextMenuStripResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTimeTaken;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.DataGridView dataGridViewOverall;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Size;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripResult;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewDetail;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveTo;
        private System.Windows.Forms.DataGridViewImageColumn col_Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_App;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Files;
    }
}
