namespace PCCleaner.Controls
{
    partial class UCUninstall
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUinstall = new System.Windows.Forms.Button();
            this.buttonRepair = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.ProgramIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LauncherPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panelActionButtons.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelActionButtons);
            this.groupBox1.Controls.Add(this.panelGrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panelActionButtons
            // 
            this.panelActionButtons.Controls.Add(this.buttonUinstall);
            this.panelActionButtons.Controls.Add(this.buttonRepair);
            this.panelActionButtons.Controls.Add(this.buttonRename);
            this.panelActionButtons.Controls.Add(this.buttonDelete);
            this.panelActionButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActionButtons.Location = new System.Drawing.Point(694, 18);
            this.panelActionButtons.Name = "panelActionButtons";
            this.panelActionButtons.Size = new System.Drawing.Size(200, 328);
            this.panelActionButtons.TabIndex = 5;
            // 
            // buttonUinstall
            // 
            this.buttonUinstall.Location = new System.Drawing.Point(3, 3);
            this.buttonUinstall.Name = "buttonUinstall";
            this.buttonUinstall.Size = new System.Drawing.Size(194, 45);
            this.buttonUinstall.TabIndex = 2;
            this.buttonUinstall.Text = "Uninstall";
            this.buttonUinstall.UseVisualStyleBackColor = true;
            this.buttonUinstall.Click += new System.EventHandler(this.buttonUinstall_Click);
            // 
            // buttonRepair
            // 
            this.buttonRepair.Location = new System.Drawing.Point(3, 54);
            this.buttonRepair.Name = "buttonRepair";
            this.buttonRepair.Size = new System.Drawing.Size(194, 45);
            this.buttonRepair.TabIndex = 3;
            this.buttonRepair.Text = "Repair";
            this.buttonRepair.UseVisualStyleBackColor = true;
            this.buttonRepair.Click += new System.EventHandler(this.buttonRepair_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(3, 105);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(194, 45);
            this.buttonRename.TabIndex = 4;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(3, 156);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(194, 45);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.AutoScroll = true;
            this.panelGrid.Controls.Add(this.dataGridViewDetail);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(3, 18);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(10);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(10, 10, 200, 10);
            this.panelGrid.Size = new System.Drawing.Size(891, 328);
            this.panelGrid.TabIndex = 4;
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.AllowUserToDeleteRows = false;
            this.dataGridViewDetail.AllowUserToResizeColumns = false;
            this.dataGridViewDetail.AllowUserToResizeRows = false;
            this.dataGridViewDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgramIcon,
            this.Program,
            this.Publisher,
            this.InstallDate,
            this.ProgramSize,
            this.Version,
            this.LauncherPath,
            this.Guid});
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.ReadOnly = true;
            this.dataGridViewDetail.RowTemplate.Height = 24;
            this.dataGridViewDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetail.ShowEditingIcon = false;
            this.dataGridViewDetail.Size = new System.Drawing.Size(681, 308);
            this.dataGridViewDetail.TabIndex = 13;
            this.dataGridViewDetail.SelectionChanged += new System.EventHandler(this.dataGridViewDetail_SelectionChanged);
            // 
            // ProgramIcon
            // 
            this.ProgramIcon.DataPropertyName = "Icon";
            this.ProgramIcon.HeaderText = "";
            this.ProgramIcon.Name = "ProgramIcon";
            this.ProgramIcon.ReadOnly = true;
            // 
            // Program
            // 
            this.Program.DataPropertyName = "ProgramName";
            this.Program.HeaderText = "Programs to Remove";
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            this.Program.Width = 470;
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            this.Publisher.Width = 200;
            // 
            // InstallDate
            // 
            this.InstallDate.DataPropertyName = "InstallDate";
            this.InstallDate.HeaderText = "Install Date";
            this.InstallDate.Name = "InstallDate";
            this.InstallDate.ReadOnly = true;
            // 
            // ProgramSize
            // 
            this.ProgramSize.DataPropertyName = "Size";
            this.ProgramSize.HeaderText = "Size";
            this.ProgramSize.Name = "ProgramSize";
            this.ProgramSize.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "Version";
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // LauncherPath
            // 
            this.LauncherPath.DataPropertyName = "UninstallString";
            this.LauncherPath.HeaderText = "LauncherPath";
            this.LauncherPath.Name = "LauncherPath";
            this.LauncherPath.ReadOnly = true;
            this.LauncherPath.Visible = false;
            // 
            // Guid
            // 
            this.Guid.DataPropertyName = "RegistryEntry";
            this.Guid.HeaderText = "Guid";
            this.Guid.Name = "Guid";
            this.Guid.ReadOnly = true;
            this.Guid.Visible = false;
            // 
            // UCUninstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCUninstall";
            this.Size = new System.Drawing.Size(897, 349);
            this.groupBox1.ResumeLayout(false);
            this.panelActionButtons.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel panelActionButtons;
        private System.Windows.Forms.Button buttonUinstall;
        private System.Windows.Forms.Button buttonRepair;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridViewImageColumn ProgramIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn LauncherPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guid;
    }
}
