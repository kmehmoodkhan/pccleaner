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
            this.listBoxSelections = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTools = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSelections)).BeginInit();
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
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(706, 546);
            this.panel1.TabIndex = 0;
            // 
            // listBoxSelections
            // 
            this.listBoxSelections.AllowUserToAddRows = false;
            this.listBoxSelections.AllowUserToResizeRows = false;
            this.listBoxSelections.BackgroundColor = System.Drawing.Color.White;
            this.listBoxSelections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.ItemType,
            this.Id});
            this.listBoxSelections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSelections.Location = new System.Drawing.Point(5, 42);
            this.listBoxSelections.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxSelections.Name = "listBoxSelections";
            this.listBoxSelections.RowHeadersVisible = false;
            this.listBoxSelections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listBoxSelections.ShowRowErrors = false;
            this.listBoxSelections.Size = new System.Drawing.Size(694, 497);
            this.listBoxSelections.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Size = new System.Drawing.Size(268, 37);
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
            this.flowLayoutPanelTools.Controls.Add(this.buttonAdd);
            this.flowLayoutPanelTools.Controls.Add(this.buttonEdit);
            this.flowLayoutPanelTools.Controls.Add(this.buttonRemove);
            this.flowLayoutPanelTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelTools.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTools.Name = "flowLayoutPanelTools";
            this.flowLayoutPanelTools.Size = new System.Drawing.Size(196, 546);
            this.flowLayoutPanelTools.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(205, 45);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(3, 54);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(205, 45);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(3, 105);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(205, 45);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.MinimumWidth = 900;
            this.Path.Name = "Path";
            this.Path.Width = 1200;
            // 
            // ItemType
            // 
            this.ItemType.HeaderText = "ItemType";
            this.ItemType.Name = "ItemType";
            this.ItemType.Visible = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSelections)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanelTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTools;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listBoxSelections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
