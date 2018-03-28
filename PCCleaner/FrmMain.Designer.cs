namespace PCCleaner
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelClientInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonTools = new System.Windows.Forms.Button();
            this.buttonRegistry = new System.Windows.Forms.Button();
            this.buttonCleaner = new System.Windows.Forms.Button();
            this.panelCleanerComponents = new System.Windows.Forms.Panel();
            this.panelRightInfo = new System.Windows.Forms.Panel();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gboxResult = new System.Windows.Forms.GroupBox();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnHeaderDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFilesSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFilesCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelActionButtons = new System.Windows.Forms.Panel();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.buttonCleaner1 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRightInfo.SuspendLayout();
            this.panelProgress.SuspendLayout();
            this.gboxResult.SuspendLayout();
            this.panelActionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelTop.Controls.Add(this.labelClientInfo);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pictureBoxLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1051, 109);
            this.panelTop.TabIndex = 0;
            // 
            // labelClientInfo
            // 
            this.labelClientInfo.AutoSize = true;
            this.labelClientInfo.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientInfo.ForeColor = System.Drawing.Color.White;
            this.labelClientInfo.Location = new System.Drawing.Point(358, 32);
            this.labelClientInfo.Name = "labelClientInfo";
            this.labelClientInfo.Size = new System.Drawing.Size(77, 15);
            this.labelClientInfo.TabIndex = 3;
            this.labelClientInfo.Text = "[System Info]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "1.0.0 Version (64 bit)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PC Cleaner";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::PCCleaner.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(18, 15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(95, 77);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.panelLeft.Controls.Add(this.buttonOptions);
            this.panelLeft.Controls.Add(this.buttonTools);
            this.panelLeft.Controls.Add(this.buttonRegistry);
            this.panelLeft.Controls.Add(this.buttonCleaner);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 109);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(133, 589);
            this.panelLeft.TabIndex = 1;
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.buttonOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOptions.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptions.ForeColor = System.Drawing.Color.White;
            this.buttonOptions.Image = global::PCCleaner.Properties.Resources.Options;
            this.buttonOptions.Location = new System.Drawing.Point(0, 300);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(133, 100);
            this.buttonOptions.TabIndex = 3;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonTools
            // 
            this.buttonTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.buttonTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTools.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTools.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTools.ForeColor = System.Drawing.Color.White;
            this.buttonTools.Image = global::PCCleaner.Properties.Resources.Tools;
            this.buttonTools.Location = new System.Drawing.Point(0, 200);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(133, 100);
            this.buttonTools.TabIndex = 2;
            this.buttonTools.Text = "Tools";
            this.buttonTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTools.UseVisualStyleBackColor = false;
            this.buttonTools.Click += new System.EventHandler(this.buttonTools_Click);
            // 
            // buttonRegistry
            // 
            this.buttonRegistry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.buttonRegistry.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegistry.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonRegistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistry.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistry.ForeColor = System.Drawing.Color.White;
            this.buttonRegistry.Image = global::PCCleaner.Properties.Resources.Registry;
            this.buttonRegistry.Location = new System.Drawing.Point(0, 100);
            this.buttonRegistry.Name = "buttonRegistry";
            this.buttonRegistry.Size = new System.Drawing.Size(133, 100);
            this.buttonRegistry.TabIndex = 1;
            this.buttonRegistry.Text = "Registry";
            this.buttonRegistry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRegistry.UseVisualStyleBackColor = false;
            this.buttonRegistry.Click += new System.EventHandler(this.buttonRegistry_Click);
            // 
            // buttonCleaner
            // 
            this.buttonCleaner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(222)))));
            this.buttonCleaner.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCleaner.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonCleaner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleaner.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleaner.ForeColor = System.Drawing.Color.White;
            this.buttonCleaner.Image = global::PCCleaner.Properties.Resources.Brush;
            this.buttonCleaner.Location = new System.Drawing.Point(0, 0);
            this.buttonCleaner.Name = "buttonCleaner";
            this.buttonCleaner.Size = new System.Drawing.Size(133, 100);
            this.buttonCleaner.TabIndex = 0;
            this.buttonCleaner.Text = "Cleaner";
            this.buttonCleaner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCleaner.UseVisualStyleBackColor = false;
            this.buttonCleaner.Click += new System.EventHandler(this.buttonCleaner_Click);
            // 
            // panelCleanerComponents
            // 
            this.panelCleanerComponents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.panelCleanerComponents.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCleanerComponents.Location = new System.Drawing.Point(133, 109);
            this.panelCleanerComponents.Name = "panelCleanerComponents";
            this.panelCleanerComponents.Size = new System.Drawing.Size(276, 589);
            this.panelCleanerComponents.TabIndex = 2;
            // 
            // panelRightInfo
            // 
            this.panelRightInfo.BackColor = System.Drawing.SystemColors.Control;
            this.panelRightInfo.Controls.Add(this.gboxResult);
            this.panelRightInfo.Controls.Add(this.panelProgress);
            this.panelRightInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightInfo.Location = new System.Drawing.Point(409, 109);
            this.panelRightInfo.Name = "panelRightInfo";
            this.panelRightInfo.Size = new System.Drawing.Size(642, 589);
            this.panelRightInfo.TabIndex = 3;
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelProgress.Controls.Add(this.progressBar1);
            this.panelProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgress.Location = new System.Drawing.Point(0, 0);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(642, 46);
            this.panelProgress.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(204)))), ((int)(((byte)(159)))));
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(642, 46);
            this.progressBar1.TabIndex = 2;
            // 
            // gboxResult
            // 
            this.gboxResult.Controls.Add(this.panelActionButtons);
            this.gboxResult.Controls.Add(this.listViewResult);
            this.gboxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxResult.Location = new System.Drawing.Point(0, 46);
            this.gboxResult.Margin = new System.Windows.Forms.Padding(40);
            this.gboxResult.Name = "gboxResult";
            this.gboxResult.Size = new System.Drawing.Size(642, 543);
            this.gboxResult.TabIndex = 2;
            this.gboxResult.TabStop = false;
            // 
            // listViewResult
            // 
            this.listViewResult.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDetail,
            this.columnHeaderFilesSize,
            this.columnHeaderFilesCount});
            this.listViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewResult.Location = new System.Drawing.Point(3, 18);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(636, 522);
            this.listViewResult.TabIndex = 0;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeaderDetail
            // 
            this.columnHeaderDetail.Width = 250;
            // 
            // columnHeaderFilesSize
            // 
            this.columnHeaderFilesSize.Width = 50;
            // 
            // columnHeaderFilesCount
            // 
            this.columnHeaderFilesCount.Width = 150;
            // 
            // panelActionButtons
            // 
            this.panelActionButtons.Controls.Add(this.buttonCleaner1);
            this.panelActionButtons.Controls.Add(this.buttonAnalyze);
            this.panelActionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionButtons.Location = new System.Drawing.Point(3, 473);
            this.panelActionButtons.Name = "panelActionButtons";
            this.panelActionButtons.Size = new System.Drawing.Size(636, 67);
            this.panelActionButtons.TabIndex = 1;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAnalyze.ForeColor = System.Drawing.Color.White;
            this.buttonAnalyze.Location = new System.Drawing.Point(15, 14);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(153, 38);
            this.buttonAnalyze.TabIndex = 0;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = false;
            // 
            // buttonCleaner1
            // 
            this.buttonCleaner1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCleaner1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCleaner1.ForeColor = System.Drawing.Color.White;
            this.buttonCleaner1.Location = new System.Drawing.Point(474, 14);
            this.buttonCleaner1.Name = "buttonCleaner1";
            this.buttonCleaner1.Size = new System.Drawing.Size(153, 38);
            this.buttonCleaner1.TabIndex = 1;
            this.buttonCleaner1.Text = "Cleaner";
            this.buttonCleaner1.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 698);
            this.Controls.Add(this.panelRightInfo);
            this.Controls.Add(this.panelCleanerComponents);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "PC-Cleaner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelRightInfo.ResumeLayout(false);
            this.panelProgress.ResumeLayout(false);
            this.gboxResult.ResumeLayout(false);
            this.panelActionButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelClientInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonCleaner;
        private System.Windows.Forms.Button buttonRegistry;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonTools;

        #endregion

        private System.Windows.Forms.Panel panelCleanerComponents;
        private System.Windows.Forms.Panel panelRightInfo;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gboxResult;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader columnHeaderDetail;
        private System.Windows.Forms.ColumnHeader columnHeaderFilesSize;
        private System.Windows.Forms.ColumnHeader columnHeaderFilesCount;
        private System.Windows.Forms.Panel panelActionButtons;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Button buttonCleaner1;
    }
}