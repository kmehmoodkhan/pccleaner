namespace PCCleaner.Controls.Options
{
    partial class FrmAddItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxRegistryKey = new System.Windows.Forms.TextBox();
            this.radioButtonRegistry = new System.Windows.Forms.RadioButton();
            this.buttonFileBrowse = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.buttonFolderBrowse = new System.Windows.Forms.Button();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.radioButtonFolder = new System.Windows.Forms.RadioButton();
            this.groupBoxChild = new System.Windows.Forms.GroupBox();
            this.textBoxFileTypeFilter = new System.Windows.Forms.TextBox();
            this.radioButtonFileTypes = new System.Windows.Forms.RadioButton();
            this.radioButtonAllFiles = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.panel1);
            this.groupBoxMain.Location = new System.Drawing.Point(13, 13);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(596, 277);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxRegistryKey);
            this.panel1.Controls.Add(this.radioButtonRegistry);
            this.panel1.Controls.Add(this.buttonFileBrowse);
            this.panel1.Controls.Add(this.textBoxFilePath);
            this.panel1.Controls.Add(this.radioButtonFile);
            this.panel1.Controls.Add(this.buttonFolderBrowse);
            this.panel1.Controls.Add(this.textBoxFolderPath);
            this.panel1.Controls.Add(this.radioButtonFolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 256);
            this.panel1.TabIndex = 0;
            // 
            // textBoxRegistryKey
            // 
            this.textBoxRegistryKey.Location = new System.Drawing.Point(18, 195);
            this.textBoxRegistryKey.Multiline = true;
            this.textBoxRegistryKey.Name = "textBoxRegistryKey";
            this.textBoxRegistryKey.Size = new System.Drawing.Size(436, 37);
            this.textBoxRegistryKey.TabIndex = 9;
            // 
            // radioButtonRegistry
            // 
            this.radioButtonRegistry.AutoSize = true;
            this.radioButtonRegistry.Location = new System.Drawing.Point(15, 168);
            this.radioButtonRegistry.Name = "radioButtonRegistry";
            this.radioButtonRegistry.Size = new System.Drawing.Size(81, 21);
            this.radioButtonRegistry.TabIndex = 8;
            this.radioButtonRegistry.TabStop = true;
            this.radioButtonRegistry.Text = "Registry";
            this.radioButtonRegistry.UseVisualStyleBackColor = true;
            this.radioButtonRegistry.CheckedChanged += new System.EventHandler(this.radioButtonRegistry_CheckedChanged);
            // 
            // buttonFileBrowse
            // 
            this.buttonFileBrowse.Location = new System.Drawing.Point(460, 123);
            this.buttonFileBrowse.Name = "buttonFileBrowse";
            this.buttonFileBrowse.Size = new System.Drawing.Size(117, 37);
            this.buttonFileBrowse.TabIndex = 7;
            this.buttonFileBrowse.Text = "Browse";
            this.buttonFileBrowse.UseVisualStyleBackColor = true;
            this.buttonFileBrowse.Click += new System.EventHandler(this.buttonFileBrowse_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(18, 123);
            this.textBoxFilePath.Multiline = true;
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(436, 37);
            this.textBoxFilePath.TabIndex = 6;
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(16, 96);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(51, 21);
            this.radioButtonFile.TabIndex = 5;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "File";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            this.radioButtonFile.CheckedChanged += new System.EventHandler(this.radioButtonFile_CheckedChanged);
            // 
            // buttonFolderBrowse
            // 
            this.buttonFolderBrowse.Location = new System.Drawing.Point(460, 42);
            this.buttonFolderBrowse.Name = "buttonFolderBrowse";
            this.buttonFolderBrowse.Size = new System.Drawing.Size(117, 37);
            this.buttonFolderBrowse.TabIndex = 4;
            this.buttonFolderBrowse.Text = "Browse";
            this.buttonFolderBrowse.UseVisualStyleBackColor = true;
            this.buttonFolderBrowse.Click += new System.EventHandler(this.buttonFolderBrowse_Click);
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Location = new System.Drawing.Point(18, 42);
            this.textBoxFolderPath.Multiline = true;
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(436, 37);
            this.textBoxFolderPath.TabIndex = 1;
            // 
            // radioButtonFolder
            // 
            this.radioButtonFolder.AutoSize = true;
            this.radioButtonFolder.Location = new System.Drawing.Point(18, 15);
            this.radioButtonFolder.Name = "radioButtonFolder";
            this.radioButtonFolder.Size = new System.Drawing.Size(123, 21);
            this.radioButtonFolder.TabIndex = 0;
            this.radioButtonFolder.TabStop = true;
            this.radioButtonFolder.Text = "Drive or Folder";
            this.radioButtonFolder.UseVisualStyleBackColor = true;
            this.radioButtonFolder.CheckedChanged += new System.EventHandler(this.radioButtonFolder_CheckedChanged);
            // 
            // groupBoxChild
            // 
            this.groupBoxChild.Controls.Add(this.textBoxFileTypeFilter);
            this.groupBoxChild.Controls.Add(this.radioButtonFileTypes);
            this.groupBoxChild.Controls.Add(this.radioButtonAllFiles);
            this.groupBoxChild.Location = new System.Drawing.Point(12, 296);
            this.groupBoxChild.Name = "groupBoxChild";
            this.groupBoxChild.Size = new System.Drawing.Size(596, 98);
            this.groupBoxChild.TabIndex = 1;
            this.groupBoxChild.TabStop = false;
            this.groupBoxChild.Text = "File Types";
            // 
            // textBoxFileTypeFilter
            // 
            this.textBoxFileTypeFilter.Location = new System.Drawing.Point(124, 53);
            this.textBoxFileTypeFilter.Multiline = true;
            this.textBoxFileTypeFilter.Name = "textBoxFileTypeFilter";
            this.textBoxFileTypeFilter.Size = new System.Drawing.Size(110, 30);
            this.textBoxFileTypeFilter.TabIndex = 10;
            // 
            // radioButtonFileTypes
            // 
            this.radioButtonFileTypes.AutoSize = true;
            this.radioButtonFileTypes.Location = new System.Drawing.Point(21, 57);
            this.radioButtonFileTypes.Name = "radioButtonFileTypes";
            this.radioButtonFileTypes.Size = new System.Drawing.Size(94, 21);
            this.radioButtonFileTypes.TabIndex = 7;
            this.radioButtonFileTypes.TabStop = true;
            this.radioButtonFileTypes.Text = "File Types";
            this.radioButtonFileTypes.UseVisualStyleBackColor = true;
            this.radioButtonFileTypes.CheckedChanged += new System.EventHandler(this.radioButtonFileTypes_CheckedChanged);
            // 
            // radioButtonAllFiles
            // 
            this.radioButtonAllFiles.AutoSize = true;
            this.radioButtonAllFiles.Location = new System.Drawing.Point(20, 32);
            this.radioButtonAllFiles.Name = "radioButtonAllFiles";
            this.radioButtonAllFiles.Size = new System.Drawing.Size(77, 21);
            this.radioButtonAllFiles.TabIndex = 6;
            this.radioButtonAllFiles.TabStop = true;
            this.radioButtonAllFiles.Text = "All Files";
            this.radioButtonAllFiles.UseVisualStyleBackColor = true;
            this.radioButtonAllFiles.CheckedChanged += new System.EventHandler(this.radioButtonAllFiles_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(492, 410);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 40);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(369, 410);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(117, 40);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FrmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 468);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxChild);
            this.Controls.Add(this.groupBoxMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddItem";
            this.Text = "Include";
            this.groupBoxMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxChild.ResumeLayout(false);
            this.groupBoxChild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.GroupBox groupBoxChild;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonFolder;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Button buttonFolderBrowse;
        private System.Windows.Forms.Button buttonFileBrowse;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.TextBox textBoxRegistryKey;
        private System.Windows.Forms.RadioButton radioButtonRegistry;
        private System.Windows.Forms.RadioButton radioButtonAllFiles;
        private System.Windows.Forms.RadioButton radioButtonFileTypes;
        private System.Windows.Forms.TextBox textBoxFileTypeFilter;
    }
}