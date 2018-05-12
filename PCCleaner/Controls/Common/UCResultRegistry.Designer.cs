namespace PCCleaner.Controls.Common
{
    partial class UCResultRegistry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.contextMenuStripRegistry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRegedit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxCheckAll = new System.Windows.Forms.CheckBox();
            this.checkBoxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.contextMenuStripRegistry.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxSelect,
            this.ColProblem,
            this.ColData,
            this.ColKey});
            this.dataGridViewDetail.ContextMenuStrip = this.contextMenuStripRegistry;
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 24;
            this.dataGridViewDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetail.ShowCellErrors = false;
            this.dataGridViewDetail.ShowCellToolTips = false;
            this.dataGridViewDetail.ShowEditingIcon = false;
            this.dataGridViewDetail.ShowRowErrors = false;
            this.dataGridViewDetail.Size = new System.Drawing.Size(614, 385);
            this.dataGridViewDetail.TabIndex = 4;
            this.dataGridViewDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetail_CellClick);
            // 
            // contextMenuStripRegistry
            // 
            this.contextMenuStripRegistry.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRegistry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRegedit,
            this.toolStripMenuItemTextFile});
            this.contextMenuStripRegistry.Name = "contextMenuStripRegistry";
            this.contextMenuStripRegistry.Size = new System.Drawing.Size(187, 52);
            // 
            // toolStripMenuItemRegedit
            // 
            this.toolStripMenuItemRegedit.Name = "toolStripMenuItemRegedit";
            this.toolStripMenuItemRegedit.Size = new System.Drawing.Size(186, 24);
            this.toolStripMenuItemRegedit.Text = "Open in Regedit";
            this.toolStripMenuItemRegedit.Click += new System.EventHandler(this.toolStripMenuItemRegedit_Click);
            // 
            // toolStripMenuItemTextFile
            // 
            this.toolStripMenuItemTextFile.Name = "toolStripMenuItemTextFile";
            this.toolStripMenuItemTextFile.Size = new System.Drawing.Size(186, 24);
            this.toolStripMenuItemTextFile.Text = "Save to Text File";
            this.toolStripMenuItemTextFile.Click += new System.EventHandler(this.toolStripMenuItemTextFile_Click);
            // 
            // checkBoxCheckAll
            // 
            this.checkBoxCheckAll.AutoSize = true;
            this.checkBoxCheckAll.Checked = true;
            this.checkBoxCheckAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckAll.Location = new System.Drawing.Point(37, 5);
            this.checkBoxCheckAll.Name = "checkBoxCheckAll";
            this.checkBoxCheckAll.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCheckAll.TabIndex = 5;
            this.checkBoxCheckAll.UseVisualStyleBackColor = true;
            this.checkBoxCheckAll.CheckedChanged += new System.EventHandler(this.checkBoxCheckAll_CheckedChanged);
            // 
            // checkBoxSelect
            // 
            this.checkBoxSelect.DataPropertyName = "IsSelected";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.NullValue = false;
            this.checkBoxSelect.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkBoxSelect.FalseValue = "false";
            this.checkBoxSelect.HeaderText = "";
            this.checkBoxSelect.Name = "checkBoxSelect";
            this.checkBoxSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkBoxSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkBoxSelect.TrueValue = "true";
            this.checkBoxSelect.Width = 70;
            // 
            // ColProblem
            // 
            this.ColProblem.DataPropertyName = "Problem";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.ColProblem.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColProblem.HeaderText = "Problem";
            this.ColProblem.Name = "ColProblem";
            this.ColProblem.Width = 170;
            // 
            // ColData
            // 
            this.ColData.DataPropertyName = "FilePath";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.ColData.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColData.HeaderText = "Data";
            this.ColData.Name = "ColData";
            this.ColData.Width = 500;
            // 
            // ColKey
            // 
            this.ColKey.DataPropertyName = "RegistryKey";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.ColKey.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColKey.HeaderText = "Registry Key";
            this.ColKey.Name = "ColKey";
            this.ColKey.Width = 400;
            // 
            // UCResultRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxCheckAll);
            this.Controls.Add(this.dataGridViewDetail);
            this.Name = "UCResultRegistry";
            this.Size = new System.Drawing.Size(614, 385);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.contextMenuStripRegistry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRegistry;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRegedit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTextFile;
        private System.Windows.Forms.CheckBox checkBoxCheckAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKey;
    }
}
