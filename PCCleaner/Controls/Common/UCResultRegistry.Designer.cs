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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ColKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // ColKey
            // 
            this.ColKey.DataPropertyName = "RegistryKey";
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            this.ColKey.DefaultCellStyle = dataGridViewCellStyle49;
            this.ColKey.HeaderText = "Registry Key";
            this.ColKey.Name = "ColKey";
            this.ColKey.Width = 400;
            // 
            // ColData
            // 
            this.ColData.DataPropertyName = "FilePath";
            dataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Control;
            this.ColData.DefaultCellStyle = dataGridViewCellStyle50;
            this.ColData.HeaderText = "Data";
            this.ColData.Name = "ColData";
            this.ColData.Width = 500;
            // 
            // ColProblem
            // 
            this.ColProblem.DataPropertyName = "Problem";
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Control;
            this.ColProblem.DefaultCellStyle = dataGridViewCellStyle51;
            this.ColProblem.HeaderText = "Problem";
            this.ColProblem.Name = "ColProblem";
            this.ColProblem.Width = 170;
            // 
            // checkBoxSelect
            // 
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle52.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle52.NullValue = false;
            this.checkBoxSelect.DefaultCellStyle = dataGridViewCellStyle52;
            this.checkBoxSelect.HeaderText = "";
            this.checkBoxSelect.Name = "checkBoxSelect";
            this.checkBoxSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkBoxSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkBoxSelect.Width = 70;
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
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 24;
            this.dataGridViewDetail.Size = new System.Drawing.Size(614, 385);
            this.dataGridViewDetail.TabIndex = 4;
            // 
            // UCResultRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDetail);
            this.Name = "UCResultRegistry";
            this.Size = new System.Drawing.Size(614, 385);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ColKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProblem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxSelect;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
    }
}
