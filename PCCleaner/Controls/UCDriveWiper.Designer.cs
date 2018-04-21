namespace PCCleaner.Controls
{
    partial class UCDriveWiper
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSecurity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWipe = new System.Windows.Forms.ComboBox();
            this.checkedListBoxDrives = new System.Windows.Forms.CheckedListBox();
            this.buttonWipe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxSecurity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxWipe);
            this.panel1.Controls.Add(this.checkedListBoxDrives);
            this.panel1.Controls.Add(this.buttonWipe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 338);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Drives";
            // 
            // comboBoxSecurity
            // 
            this.comboBoxSecurity.FormattingEnabled = true;
            this.comboBoxSecurity.Location = new System.Drawing.Point(114, 68);
            this.comboBoxSecurity.Name = "comboBoxSecurity";
            this.comboBoxSecurity.Size = new System.Drawing.Size(257, 24);
            this.comboBoxSecurity.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Security";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wipe";
            // 
            // comboBoxWipe
            // 
            this.comboBoxWipe.FormattingEnabled = true;
            this.comboBoxWipe.Location = new System.Drawing.Point(114, 22);
            this.comboBoxWipe.Name = "comboBoxWipe";
            this.comboBoxWipe.Size = new System.Drawing.Size(257, 24);
            this.comboBoxWipe.TabIndex = 14;
            // 
            // checkedListBoxDrives
            // 
            this.checkedListBoxDrives.FormattingEnabled = true;
            this.checkedListBoxDrives.Location = new System.Drawing.Point(114, 114);
            this.checkedListBoxDrives.Name = "checkedListBoxDrives";
            this.checkedListBoxDrives.Size = new System.Drawing.Size(257, 89);
            this.checkedListBoxDrives.TabIndex = 18;
            // 
            // buttonWipe
            // 
            this.buttonWipe.Location = new System.Drawing.Point(263, 219);
            this.buttonWipe.Name = "buttonWipe";
            this.buttonWipe.Size = new System.Drawing.Size(108, 38);
            this.buttonWipe.TabIndex = 12;
            this.buttonWipe.Text = "Wipe";
            this.buttonWipe.UseVisualStyleBackColor = true;
            // 
            // UCDriveWiper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCDriveWiper";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(539, 344);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSecurity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWipe;
        private System.Windows.Forms.CheckedListBox checkedListBoxDrives;
        private System.Windows.Forms.Button buttonWipe;
    }
}
