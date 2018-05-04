namespace PCCleaner.Controls
{
    partial class UCStartup
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
            this.panelActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tabControlStartup = new System.Windows.Forms.TabControl();
            this.tabWindows = new System.Windows.Forms.TabPage();
            this.dataGridViewWindows = new System.Windows.Forms.DataGridView();
            this.Col_Enable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IsEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPageScheduledTasks = new System.Windows.Forms.TabPage();
            this.dataGridViewScheduledTasks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageContextMenu = new System.Windows.Forms.TabPage();
            this.dataGridViewContextMenu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActionButtons.SuspendLayout();
            this.tabControlStartup.SuspendLayout();
            this.tabWindows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWindows)).BeginInit();
            this.tabPageScheduledTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScheduledTasks)).BeginInit();
            this.tabPageContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContextMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActionButtons
            // 
            this.panelActionButtons.Controls.Add(this.buttonEnable);
            this.panelActionButtons.Controls.Add(this.buttonDisable);
            this.panelActionButtons.Controls.Add(this.buttonDelete);
            this.panelActionButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActionButtons.Location = new System.Drawing.Point(562, 0);
            this.panelActionButtons.Name = "panelActionButtons";
            this.panelActionButtons.Size = new System.Drawing.Size(200, 355);
            this.panelActionButtons.TabIndex = 6;
            // 
            // buttonEnable
            // 
            this.buttonEnable.Location = new System.Drawing.Point(3, 3);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(194, 45);
            this.buttonEnable.TabIndex = 2;
            this.buttonEnable.Text = "Enable";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // buttonDisable
            // 
            this.buttonDisable.Location = new System.Drawing.Point(3, 54);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(194, 45);
            this.buttonDisable.TabIndex = 4;
            this.buttonDisable.Text = "Disable";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(3, 105);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(194, 45);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // tabControlStartup
            // 
            this.tabControlStartup.Controls.Add(this.tabWindows);
            this.tabControlStartup.Controls.Add(this.tabPageScheduledTasks);
            this.tabControlStartup.Controls.Add(this.tabPageContextMenu);
            this.tabControlStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStartup.ItemSize = new System.Drawing.Size(67, 21);
            this.tabControlStartup.Location = new System.Drawing.Point(0, 0);
            this.tabControlStartup.Name = "tabControlStartup";
            this.tabControlStartup.SelectedIndex = 0;
            this.tabControlStartup.Size = new System.Drawing.Size(562, 355);
            this.tabControlStartup.TabIndex = 7;
            this.tabControlStartup.SelectedIndexChanged += new System.EventHandler(this.tabControlStartup_SelectedIndexChanged);
            // 
            // tabWindows
            // 
            this.tabWindows.Controls.Add(this.dataGridViewWindows);
            this.tabWindows.Location = new System.Drawing.Point(4, 25);
            this.tabWindows.Name = "tabWindows";
            this.tabWindows.Padding = new System.Windows.Forms.Padding(3);
            this.tabWindows.Size = new System.Drawing.Size(554, 326);
            this.tabWindows.TabIndex = 0;
            this.tabWindows.Text = "Windows";
            this.tabWindows.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWindows
            // 
            this.dataGridViewWindows.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewWindows.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewWindows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewWindows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Enable,
            this.Col_Key,
            this.Col_Program,
            this.Col_Publisher,
            this.Col_File,
            this.Col_IsEnabled});
            this.dataGridViewWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWindows.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWindows.Name = "dataGridViewWindows";
            this.dataGridViewWindows.RowHeadersVisible = false;
            this.dataGridViewWindows.RowTemplate.Height = 24;
            this.dataGridViewWindows.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewWindows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWindows.Size = new System.Drawing.Size(548, 320);
            this.dataGridViewWindows.TabIndex = 0;
            this.dataGridViewWindows.SelectionChanged += new System.EventHandler(this.dataGridViewWindows_SelectionChanged);
            // 
            // Col_Enable
            // 
            this.Col_Enable.DataPropertyName = "IsEnabledText";
            this.Col_Enable.HeaderText = "Enable";
            this.Col_Enable.Name = "Col_Enable";
            this.Col_Enable.ReadOnly = true;
            // 
            // Col_Key
            // 
            this.Col_Key.DataPropertyName = "RegistryKey";
            this.Col_Key.HeaderText = "Key";
            this.Col_Key.Name = "Col_Key";
            this.Col_Key.ReadOnly = true;
            // 
            // Col_Program
            // 
            this.Col_Program.DataPropertyName = "ProgramName";
            this.Col_Program.HeaderText = "Program";
            this.Col_Program.Name = "Col_Program";
            this.Col_Program.ReadOnly = true;
            // 
            // Col_Publisher
            // 
            this.Col_Publisher.DataPropertyName = "Publisher";
            this.Col_Publisher.HeaderText = "Publisher";
            this.Col_Publisher.Name = "Col_Publisher";
            this.Col_Publisher.ReadOnly = true;
            // 
            // Col_File
            // 
            this.Col_File.DataPropertyName = "LauncherFile";
            this.Col_File.HeaderText = "File";
            this.Col_File.Name = "Col_File";
            this.Col_File.ReadOnly = true;
            this.Col_File.Width = 500;
            // 
            // Col_IsEnabled
            // 
            this.Col_IsEnabled.DataPropertyName = "IsEnabled";
            this.Col_IsEnabled.HeaderText = "Column1";
            this.Col_IsEnabled.Name = "Col_IsEnabled";
            this.Col_IsEnabled.Visible = false;
            // 
            // tabPageScheduledTasks
            // 
            this.tabPageScheduledTasks.Controls.Add(this.dataGridViewScheduledTasks);
            this.tabPageScheduledTasks.Location = new System.Drawing.Point(4, 25);
            this.tabPageScheduledTasks.Name = "tabPageScheduledTasks";
            this.tabPageScheduledTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScheduledTasks.Size = new System.Drawing.Size(554, 326);
            this.tabPageScheduledTasks.TabIndex = 1;
            this.tabPageScheduledTasks.Text = "Scheduled Tasks";
            this.tabPageScheduledTasks.UseVisualStyleBackColor = true;
            // 
            // dataGridViewScheduledTasks
            // 
            this.dataGridViewScheduledTasks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewScheduledTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewScheduledTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewScheduledTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewScheduledTasks.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewScheduledTasks.Name = "dataGridViewScheduledTasks";
            this.dataGridViewScheduledTasks.RowHeadersVisible = false;
            this.dataGridViewScheduledTasks.RowTemplate.Height = 24;
            this.dataGridViewScheduledTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewScheduledTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScheduledTasks.Size = new System.Drawing.Size(548, 320);
            this.dataGridViewScheduledTasks.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Enable";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Key";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Program";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "File";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 500;
            // 
            // tabPageContextMenu
            // 
            this.tabPageContextMenu.Controls.Add(this.dataGridViewContextMenu);
            this.tabPageContextMenu.Location = new System.Drawing.Point(4, 25);
            this.tabPageContextMenu.Name = "tabPageContextMenu";
            this.tabPageContextMenu.Size = new System.Drawing.Size(554, 326);
            this.tabPageContextMenu.TabIndex = 2;
            this.tabPageContextMenu.Text = "Context Menu";
            this.tabPageContextMenu.UseVisualStyleBackColor = true;
            // 
            // dataGridViewContextMenu
            // 
            this.dataGridViewContextMenu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewContextMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewContextMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewContextMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContextMenu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewContextMenu.Name = "dataGridViewContextMenu";
            this.dataGridViewContextMenu.RowHeadersVisible = false;
            this.dataGridViewContextMenu.RowTemplate.Height = 24;
            this.dataGridViewContextMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewContextMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContextMenu.Size = new System.Drawing.Size(554, 326);
            this.dataGridViewContextMenu.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Enable";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Key";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Program";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "File";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 500;
            // 
            // UCStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlStartup);
            this.Controls.Add(this.panelActionButtons);
            this.Name = "UCStartup";
            this.Size = new System.Drawing.Size(762, 355);
            this.panelActionButtons.ResumeLayout(false);
            this.tabControlStartup.ResumeLayout(false);
            this.tabWindows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWindows)).EndInit();
            this.tabPageScheduledTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScheduledTasks)).EndInit();
            this.tabPageContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContextMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelActionButtons;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TabControl tabControlStartup;
        private System.Windows.Forms.TabPage tabWindows;
        private System.Windows.Forms.TabPage tabPageScheduledTasks;
        private System.Windows.Forms.TabPage tabPageContextMenu;
        private System.Windows.Forms.DataGridView dataGridViewWindows;
        private System.Windows.Forms.DataGridView dataGridViewScheduledTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dataGridViewContextMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Enable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_File;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_IsEnabled;
    }
}
