namespace PCCleaner.Controls.Options
{
    partial class UCSettings
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
            this.checkBoxWipeCluster = new System.Windows.Forms.CheckBox();
            this.checkBoxWipeAlternate = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAddOpenOption = new System.Windows.Forms.CheckBox();
            this.checkBoxAddRunToRecycleBin = new System.Windows.Forms.CheckBox();
            this.checkBoxRunOption = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxSecureDeletion = new System.Windows.Forms.RadioButton();
            this.checkBoxNormalDeletion = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.checkBoxWipeCluster);
            this.panel1.Controls.Add(this.checkBoxWipeAlternate);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBoxAddOpenOption);
            this.panel1.Controls.Add(this.checkBoxAddRunToRecycleBin);
            this.panel1.Controls.Add(this.checkBoxRunOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 473);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxWipeCluster
            // 
            this.checkBoxWipeCluster.AutoSize = true;
            this.checkBoxWipeCluster.Location = new System.Drawing.Point(162, 283);
            this.checkBoxWipeCluster.Name = "checkBoxWipeCluster";
            this.checkBoxWipeCluster.Size = new System.Drawing.Size(141, 21);
            this.checkBoxWipeCluster.TabIndex = 23;
            this.checkBoxWipeCluster.Text = "Wipe Cluster Tips";
            this.checkBoxWipeCluster.UseVisualStyleBackColor = true;
            // 
            // checkBoxWipeAlternate
            // 
            this.checkBoxWipeAlternate.AutoSize = true;
            this.checkBoxWipeAlternate.Location = new System.Drawing.Point(162, 252);
            this.checkBoxWipeAlternate.Name = "checkBoxWipeAlternate";
            this.checkBoxWipeAlternate.Size = new System.Drawing.Size(213, 21);
            this.checkBoxWipeAlternate.TabIndex = 22;
            this.checkBoxWipeAlternate.Text = "Wipe Alternate Data Streams";
            this.checkBoxWipeAlternate.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English"});
            this.comboBox1.Location = new System.Drawing.Point(162, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Secure Deletion";
            // 
            // checkBoxAddOpenOption
            // 
            this.checkBoxAddOpenOption.AutoSize = true;
            this.checkBoxAddOpenOption.Location = new System.Drawing.Point(25, 91);
            this.checkBoxAddOpenOption.Name = "checkBoxAddOpenOption";
            this.checkBoxAddOpenOption.Size = new System.Drawing.Size(294, 21);
            this.checkBoxAddOpenOption.TabIndex = 16;
            this.checkBoxAddOpenOption.Text = "Add \"Open Cleaner\" option to Recycle Bin";
            this.checkBoxAddOpenOption.UseVisualStyleBackColor = true;
            this.checkBoxAddOpenOption.CheckedChanged += new System.EventHandler(this.checkBoxAddOpenOption_CheckedChanged);
            // 
            // checkBoxAddRunToRecycleBin
            // 
            this.checkBoxAddRunToRecycleBin.AutoSize = true;
            this.checkBoxAddRunToRecycleBin.Location = new System.Drawing.Point(25, 58);
            this.checkBoxAddRunToRecycleBin.Name = "checkBoxAddRunToRecycleBin";
            this.checkBoxAddRunToRecycleBin.Size = new System.Drawing.Size(375, 21);
            this.checkBoxAddRunToRecycleBin.TabIndex = 15;
            this.checkBoxAddRunToRecycleBin.Text = "Add \"Run Cleaner\" option to Recycle Bin Context Menu";
            this.checkBoxAddRunToRecycleBin.UseVisualStyleBackColor = true;
            this.checkBoxAddRunToRecycleBin.CheckedChanged += new System.EventHandler(this.checkBoxAddRunToRecycleBin_CheckedChanged);
            // 
            // checkBoxRunOption
            // 
            this.checkBoxRunOption.AutoSize = true;
            this.checkBoxRunOption.Location = new System.Drawing.Point(25, 25);
            this.checkBoxRunOption.Name = "checkBoxRunOption";
            this.checkBoxRunOption.Size = new System.Drawing.Size(266, 21);
            this.checkBoxRunOption.TabIndex = 14;
            this.checkBoxRunOption.Text = "Run PCCleaner when computer starts";
            this.checkBoxRunOption.UseVisualStyleBackColor = true;
            this.checkBoxRunOption.CheckedChanged += new System.EventHandler(this.checkBoxRunOption_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxSecureDeletion);
            this.panel2.Controls.Add(this.checkBoxNormalDeletion);
            this.panel2.Location = new System.Drawing.Point(126, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 62);
            this.panel2.TabIndex = 24;
            // 
            // checkBoxSecureDeletion
            // 
            this.checkBoxSecureDeletion.AutoSize = true;
            this.checkBoxSecureDeletion.Location = new System.Drawing.Point(35, 36);
            this.checkBoxSecureDeletion.Name = "checkBoxSecureDeletion";
            this.checkBoxSecureDeletion.Size = new System.Drawing.Size(212, 21);
            this.checkBoxSecureDeletion.TabIndex = 22;
            this.checkBoxSecureDeletion.Text = "Secure File Deletion (Slower)";
            this.checkBoxSecureDeletion.UseVisualStyleBackColor = true;
            this.checkBoxSecureDeletion.CheckedChanged += new System.EventHandler(this.checkBoxSecureDeletion_CheckedChanged);
            // 
            // checkBoxNormalDeletion
            // 
            this.checkBoxNormalDeletion.AutoSize = true;
            this.checkBoxNormalDeletion.Location = new System.Drawing.Point(35, 5);
            this.checkBoxNormalDeletion.Name = "checkBoxNormalDeletion";
            this.checkBoxNormalDeletion.Size = new System.Drawing.Size(210, 21);
            this.checkBoxNormalDeletion.TabIndex = 21;
            this.checkBoxNormalDeletion.Text = "Normal File Deletion (Faster)";
            this.checkBoxNormalDeletion.UseVisualStyleBackColor = true;
            this.checkBoxNormalDeletion.CheckedChanged += new System.EventHandler(this.checkBoxNormalDeletion_CheckedChanged);
            // 
            // UCSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCSettings";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(715, 479);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxWipeCluster;
        private System.Windows.Forms.CheckBox checkBoxWipeAlternate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAddOpenOption;
        private System.Windows.Forms.CheckBox checkBoxAddRunToRecycleBin;
        private System.Windows.Forms.CheckBox checkBoxRunOption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton checkBoxSecureDeletion;
        private System.Windows.Forms.RadioButton checkBoxNormalDeletion;
    }
}
