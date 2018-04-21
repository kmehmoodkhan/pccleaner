namespace PCCleaner.Controls
{
    partial class UCBrowserPlugins
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
            this.dataGridViewChrome = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageChrome = new System.Windows.Forms.TabPage();
            this.tabPageFirefox = new System.Windows.Forms.TabPage();
            this.dataGridViewWindows = new System.Windows.Forms.DataGridView();
            this.Col_Enable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabIE = new System.Windows.Forms.TabPage();
            this.tabControlStartup = new System.Windows.Forms.TabControl();
            this.buttonUinstall = new System.Windows.Forms.Button();
            this.buttonRepair = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewFirefox = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChrome)).BeginInit();
            this.tabPageChrome.SuspendLayout();
            this.tabPageFirefox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWindows)).BeginInit();
            this.tabIE.SuspendLayout();
            this.tabControlStartup.SuspendLayout();
            this.panelActionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirefox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChrome
            // 
            this.dataGridViewChrome.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewChrome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewChrome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewChrome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewChrome.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewChrome.Name = "dataGridViewChrome";
            this.dataGridViewChrome.RowHeadersVisible = false;
            this.dataGridViewChrome.RowTemplate.Height = 24;
            this.dataGridViewChrome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewChrome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChrome.Size = new System.Drawing.Size(645, 355);
            this.dataGridViewChrome.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Enable";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Key";
            this.dataGridViewTextBoxColumn2.HeaderText = "Key";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Program";
            this.dataGridViewTextBoxColumn3.HeaderText = "Program";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn4.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FilePath";
            this.dataGridViewTextBoxColumn5.HeaderText = "File";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 500;
            // 
            // tabPageChrome
            // 
            this.tabPageChrome.Controls.Add(this.dataGridViewChrome);
            this.tabPageChrome.Location = new System.Drawing.Point(4, 25);
            this.tabPageChrome.Name = "tabPageChrome";
            this.tabPageChrome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChrome.Size = new System.Drawing.Size(651, 361);
            this.tabPageChrome.TabIndex = 1;
            this.tabPageChrome.Text = "Google Chrome                    ";
            this.tabPageChrome.UseVisualStyleBackColor = true;
            // 
            // tabPageFirefox
            // 
            this.tabPageFirefox.Controls.Add(this.dataGridViewFirefox);
            this.tabPageFirefox.Location = new System.Drawing.Point(4, 25);
            this.tabPageFirefox.Name = "tabPageFirefox";
            this.tabPageFirefox.Size = new System.Drawing.Size(651, 361);
            this.tabPageFirefox.TabIndex = 2;
            this.tabPageFirefox.Text = "Firefox                 ";
            this.tabPageFirefox.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWindows
            // 
            this.dataGridViewWindows.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewWindows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewWindows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Enable,
            this.Col_Key,
            this.Col_Program,
            this.Col_Publisher,
            this.Col_File});
            this.dataGridViewWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWindows.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWindows.Name = "dataGridViewWindows";
            this.dataGridViewWindows.RowHeadersVisible = false;
            this.dataGridViewWindows.RowTemplate.Height = 24;
            this.dataGridViewWindows.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewWindows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWindows.Size = new System.Drawing.Size(645, 355);
            this.dataGridViewWindows.TabIndex = 0;
            // 
            // Col_Enable
            // 
            this.Col_Enable.HeaderText = "Enable";
            this.Col_Enable.Name = "Col_Enable";
            this.Col_Enable.ReadOnly = true;
            // 
            // Col_Key
            // 
            this.Col_Key.DataPropertyName = "Key";
            this.Col_Key.HeaderText = "Key";
            this.Col_Key.Name = "Col_Key";
            this.Col_Key.ReadOnly = true;
            // 
            // Col_Program
            // 
            this.Col_Program.DataPropertyName = "Program";
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
            this.Col_File.DataPropertyName = "FilePath";
            this.Col_File.HeaderText = "File";
            this.Col_File.Name = "Col_File";
            this.Col_File.ReadOnly = true;
            this.Col_File.Width = 500;
            // 
            // tabIE
            // 
            this.tabIE.Controls.Add(this.dataGridViewWindows);
            this.tabIE.Location = new System.Drawing.Point(4, 25);
            this.tabIE.Name = "tabIE";
            this.tabIE.Padding = new System.Windows.Forms.Padding(3);
            this.tabIE.Size = new System.Drawing.Size(651, 361);
            this.tabIE.TabIndex = 0;
            this.tabIE.Text = "Internet Explorer       ";
            this.tabIE.UseVisualStyleBackColor = true;
            // 
            // tabControlStartup
            // 
            this.tabControlStartup.Controls.Add(this.tabIE);
            this.tabControlStartup.Controls.Add(this.tabPageChrome);
            this.tabControlStartup.Controls.Add(this.tabPageFirefox);
            this.tabControlStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStartup.ItemSize = new System.Drawing.Size(67, 21);
            this.tabControlStartup.Location = new System.Drawing.Point(0, 0);
            this.tabControlStartup.Name = "tabControlStartup";
            this.tabControlStartup.SelectedIndex = 0;
            this.tabControlStartup.Size = new System.Drawing.Size(659, 390);
            this.tabControlStartup.TabIndex = 9;
            this.tabControlStartup.SelectedIndexChanged += new System.EventHandler(this.tabControlStartup_SelectedIndexChanged);
            // 
            // buttonUinstall
            // 
            this.buttonUinstall.Location = new System.Drawing.Point(3, 3);
            this.buttonUinstall.Name = "buttonUinstall";
            this.buttonUinstall.Size = new System.Drawing.Size(194, 45);
            this.buttonUinstall.TabIndex = 2;
            this.buttonUinstall.Text = "Uninstall";
            this.buttonUinstall.UseVisualStyleBackColor = true;
            // 
            // buttonRepair
            // 
            this.buttonRepair.Location = new System.Drawing.Point(3, 54);
            this.buttonRepair.Name = "buttonRepair";
            this.buttonRepair.Size = new System.Drawing.Size(194, 45);
            this.buttonRepair.TabIndex = 3;
            this.buttonRepair.Text = "Repair";
            this.buttonRepair.UseVisualStyleBackColor = true;
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
            // 
            // panelActionButtons
            // 
            this.panelActionButtons.Controls.Add(this.buttonUinstall);
            this.panelActionButtons.Controls.Add(this.buttonRepair);
            this.panelActionButtons.Controls.Add(this.buttonRename);
            this.panelActionButtons.Controls.Add(this.buttonDelete);
            this.panelActionButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActionButtons.Location = new System.Drawing.Point(659, 0);
            this.panelActionButtons.Name = "panelActionButtons";
            this.panelActionButtons.Size = new System.Drawing.Size(200, 390);
            this.panelActionButtons.TabIndex = 8;
            // 
            // dataGridViewFirefox
            // 
            this.dataGridViewFirefox.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFirefox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewFirefox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewFirefox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFirefox.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFirefox.Name = "dataGridViewFirefox";
            this.dataGridViewFirefox.RowHeadersVisible = false;
            this.dataGridViewFirefox.RowTemplate.Height = 24;
            this.dataGridViewFirefox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFirefox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFirefox.Size = new System.Drawing.Size(651, 361);
            this.dataGridViewFirefox.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Enable";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Key";
            this.dataGridViewTextBoxColumn7.HeaderText = "Key";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Program";
            this.dataGridViewTextBoxColumn8.HeaderText = "Program";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn9.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FilePath";
            this.dataGridViewTextBoxColumn10.HeaderText = "File";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 500;
            // 
            // UCBrowserPlugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlStartup);
            this.Controls.Add(this.panelActionButtons);
            this.Name = "UCBrowserPlugins";
            this.Size = new System.Drawing.Size(859, 390);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChrome)).EndInit();
            this.tabPageChrome.ResumeLayout(false);
            this.tabPageFirefox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWindows)).EndInit();
            this.tabIE.ResumeLayout(false);
            this.tabControlStartup.ResumeLayout(false);
            this.panelActionButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirefox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewChrome;
        private System.Windows.Forms.TabPage tabPageChrome;
        private System.Windows.Forms.TabPage tabPageFirefox;
        private System.Windows.Forms.DataGridView dataGridViewWindows;
        private System.Windows.Forms.TabPage tabIE;
        private System.Windows.Forms.TabControl tabControlStartup;
        private System.Windows.Forms.Button buttonUinstall;
        private System.Windows.Forms.Button buttonRepair;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.FlowLayoutPanel panelActionButtons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Enable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_File;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dataGridViewFirefox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}
