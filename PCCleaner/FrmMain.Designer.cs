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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProductActivation = new System.Windows.Forms.Label();
            this.labelTrialPeriodLeft = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelClientInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCleaner = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonTools = new System.Windows.Forms.Button();
            this.buttonRegistry = new System.Windows.Forms.Button();
            this.panelRightInfo = new System.Windows.Forms.Panel();
            this.gboxResult = new System.Windows.Forms.GroupBox();
            this.panelActionButtons = new System.Windows.Forms.Panel();
            this.buttonCleaner1 = new System.Windows.Forms.Button();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelCleanerComponents = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.ucResult = new PCCleaner.Controls.Common.UCResult();
            this.ucCleaner1 = new PCCleaner.Controls.UCCleaner();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRightInfo.SuspendLayout();
            this.gboxResult.SuspendLayout();
            this.panelActionButtons.SuspendLayout();
            this.panelProgress.SuspendLayout();
            this.panelCleanerComponents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.panelLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 109);
            this.panelTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProductActivation);
            this.panel1.Controls.Add(this.labelTrialPeriodLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(916, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 109);
            this.panel1.TabIndex = 6;
            // 
            // labelProductActivation
            // 
            this.labelProductActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductActivation.ForeColor = System.Drawing.Color.Red;
            this.labelProductActivation.Location = new System.Drawing.Point(94, 21);
            this.labelProductActivation.Name = "labelProductActivation";
            this.labelProductActivation.Size = new System.Drawing.Size(160, 34);
            this.labelProductActivation.TabIndex = 7;
            this.labelProductActivation.Text = "[Not Activated]";
            // 
            // labelTrialPeriodLeft
            // 
            this.labelTrialPeriodLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTrialPeriodLeft.AutoSize = true;
            this.labelTrialPeriodLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrialPeriodLeft.ForeColor = System.Drawing.Color.White;
            this.labelTrialPeriodLeft.Location = new System.Drawing.Point(94, 67);
            this.labelTrialPeriodLeft.Name = "labelTrialPeriodLeft";
            this.labelTrialPeriodLeft.Size = new System.Drawing.Size(160, 25);
            this.labelTrialPeriodLeft.TabIndex = 8;
            this.labelTrialPeriodLeft.Text = "[Trial Period Left]";
            // 
            // panelLogo
            // 
            this.panelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogo.Controls.Add(this.labelClientInfo);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Location = new System.Drawing.Point(255, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(672, 103);
            this.panelLogo.TabIndex = 5;
            // 
            // labelClientInfo
            // 
            this.labelClientInfo.AutoSize = true;
            this.labelClientInfo.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientInfo.ForeColor = System.Drawing.Color.White;
            this.labelClientInfo.Location = new System.Drawing.Point(117, 54);
            this.labelClientInfo.Name = "labelClientInfo";
            this.labelClientInfo.Size = new System.Drawing.Size(77, 15);
            this.labelClientInfo.TabIndex = 7;
            this.labelClientInfo.Text = "[System Info]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "1.0.0 Version (64 bit)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "PCOptimizer";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::PCCleaner.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(15, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(95, 77);
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.panelLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panelLeft.ColumnCount = 4;
            this.panelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelLeft.Controls.Add(this.buttonCleaner, 0, 0);
            this.panelLeft.Controls.Add(this.buttonOptions, 3, 0);
            this.panelLeft.Controls.Add(this.buttonTools, 2, 0);
            this.panelLeft.Controls.Add(this.buttonRegistry, 1, 0);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeft.Location = new System.Drawing.Point(0, 109);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.RowCount = 1;
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.panelLeft.Size = new System.Drawing.Size(1182, 80);
            this.panelLeft.TabIndex = 1;
            // 
            // buttonCleaner
            // 
            this.buttonCleaner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(222)))));
            this.buttonCleaner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCleaner.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonCleaner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleaner.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleaner.ForeColor = System.Drawing.Color.White;
            this.buttonCleaner.Image = global::PCCleaner.Properties.Resources.Brush;
            this.buttonCleaner.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCleaner.Location = new System.Drawing.Point(4, 4);
            this.buttonCleaner.Name = "buttonCleaner";
            this.buttonCleaner.Size = new System.Drawing.Size(288, 90);
            this.buttonCleaner.TabIndex = 4;
            this.buttonCleaner.Text = "Cleaner";
            this.buttonCleaner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCleaner.UseVisualStyleBackColor = false;
            this.buttonCleaner.Click += new System.EventHandler(this.buttonCleaner_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.buttonOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOptions.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptions.ForeColor = System.Drawing.Color.White;
            this.buttonOptions.Image = global::PCCleaner.Properties.Resources.Options;
            this.buttonOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOptions.Location = new System.Drawing.Point(889, 4);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(289, 90);
            this.buttonOptions.TabIndex = 3;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonTools
            // 
            this.buttonTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.buttonTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTools.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTools.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTools.ForeColor = System.Drawing.Color.White;
            this.buttonTools.Image = global::PCCleaner.Properties.Resources.Tools;
            this.buttonTools.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTools.Location = new System.Drawing.Point(594, 4);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(288, 90);
            this.buttonTools.TabIndex = 2;
            this.buttonTools.Text = "Tools";
            this.buttonTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTools.UseVisualStyleBackColor = false;
            this.buttonTools.Click += new System.EventHandler(this.buttonTools_Click);
            // 
            // buttonRegistry
            // 
            this.buttonRegistry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.buttonRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRegistry.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonRegistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistry.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistry.ForeColor = System.Drawing.Color.White;
            this.buttonRegistry.Image = global::PCCleaner.Properties.Resources.Registry_Left;
            this.buttonRegistry.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegistry.Location = new System.Drawing.Point(299, 4);
            this.buttonRegistry.Name = "buttonRegistry";
            this.buttonRegistry.Size = new System.Drawing.Size(288, 90);
            this.buttonRegistry.TabIndex = 1;
            this.buttonRegistry.Text = "Registry";
            this.buttonRegistry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegistry.UseVisualStyleBackColor = false;
            this.buttonRegistry.Click += new System.EventHandler(this.buttonRegistry_Click);
            // 
            // panelRightInfo
            // 
            this.panelRightInfo.BackColor = System.Drawing.SystemColors.Control;
            this.panelRightInfo.Controls.Add(this.gboxResult);
            this.panelRightInfo.Controls.Add(this.panelProgress);
            this.panelRightInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightInfo.Location = new System.Drawing.Point(302, 189);
            this.panelRightInfo.Name = "panelRightInfo";
            this.panelRightInfo.Size = new System.Drawing.Size(880, 866);
            this.panelRightInfo.TabIndex = 3;
            // 
            // gboxResult
            // 
            this.gboxResult.BackColor = System.Drawing.SystemColors.Control;
            this.gboxResult.Controls.Add(this.ucResult);
            this.gboxResult.Controls.Add(this.panelActionButtons);
            this.gboxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxResult.Location = new System.Drawing.Point(0, 46);
            this.gboxResult.Margin = new System.Windows.Forms.Padding(40);
            this.gboxResult.Name = "gboxResult";
            this.gboxResult.Size = new System.Drawing.Size(880, 820);
            this.gboxResult.TabIndex = 2;
            this.gboxResult.TabStop = false;
            // 
            // panelActionButtons
            // 
            this.panelActionButtons.Controls.Add(this.buttonCleaner1);
            this.panelActionButtons.Controls.Add(this.buttonAnalyze);
            this.panelActionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionButtons.Location = new System.Drawing.Point(3, 750);
            this.panelActionButtons.Name = "panelActionButtons";
            this.panelActionButtons.Size = new System.Drawing.Size(874, 67);
            this.panelActionButtons.TabIndex = 1;
            // 
            // buttonCleaner1
            // 
            this.buttonCleaner1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCleaner1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCleaner1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleaner1.ForeColor = System.Drawing.Color.White;
            this.buttonCleaner1.Location = new System.Drawing.Point(710, 14);
            this.buttonCleaner1.Name = "buttonCleaner1";
            this.buttonCleaner1.Size = new System.Drawing.Size(153, 38);
            this.buttonCleaner1.TabIndex = 1;
            this.buttonCleaner1.Text = "Run Cleaner";
            this.buttonCleaner1.UseVisualStyleBackColor = false;
            this.buttonCleaner1.Click += new System.EventHandler(this.buttonCleaner1_Click);
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalyze.ForeColor = System.Drawing.Color.White;
            this.buttonAnalyze.Location = new System.Drawing.Point(15, 14);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(153, 38);
            this.buttonAnalyze.TabIndex = 0;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = false;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.Color.Transparent;
            this.panelProgress.Controls.Add(this.progressBar1);
            this.panelProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgress.Location = new System.Drawing.Point(0, 0);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(880, 46);
            this.panelProgress.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(204)))), ((int)(((byte)(159)))));
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.Location = new System.Drawing.Point(0, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(880, 25);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // panelCleanerComponents
            // 
            this.panelCleanerComponents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.panelCleanerComponents.Controls.Add(this.ucCleaner1);
            this.panelCleanerComponents.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCleanerComponents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelCleanerComponents.Location = new System.Drawing.Point(0, 189);
            this.panelCleanerComponents.Name = "panelCleanerComponents";
            this.panelCleanerComponents.Size = new System.Drawing.Size(302, 866);
            this.panelCleanerComponents.TabIndex = 2;
            // 
            // backgroundWorkerSearch
            // 
            this.backgroundWorkerSearch.WorkerReportsProgress = true;
            this.backgroundWorkerSearch.WorkerSupportsCancellation = true;
            this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSearch_DoWork);
            this.backgroundWorkerSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSearch_ProgressChanged);
            this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSearch_RunWorkerCompleted);
            // 
            // ucResult
            // 
            this.ucResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucResult.Location = new System.Drawing.Point(3, 18);
            this.ucResult.Name = "ucResult";
            this.ucResult.ResultView = PCCleaner.Common.ResultView.Overall;
            this.ucResult.Size = new System.Drawing.Size(874, 732);
            this.ucResult.TabIndex = 2;
            // 
            // ucCleaner1
            // 
            this.ucCleaner1.Location = new System.Drawing.Point(3, 3);
            this.ucCleaner1.Name = "ucCleaner1";
            this.ucCleaner1.Size = new System.Drawing.Size(276, 1124);
            this.ucCleaner1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.panelRightInfo);
            this.Controls.Add(this.panelCleanerComponents);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCOptimizer";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelRightInfo.ResumeLayout(false);
            this.gboxResult.ResumeLayout(false);
            this.panelActionButtons.ResumeLayout(false);
            this.panelProgress.ResumeLayout(false);
            this.panelCleanerComponents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel panelLeft;
        private System.Windows.Forms.Button buttonRegistry;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonTools;

        #endregion
        private System.Windows.Forms.Panel panelRightInfo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gboxResult;
        private System.Windows.Forms.Panel panelActionButtons;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Button buttonCleaner1;
        private System.Windows.Forms.FlowLayoutPanel panelCleanerComponents;
        private Controls.UCCleaner ucCleaner1;
        public System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.Windows.Forms.Panel panelProgress;
        private Controls.Common.UCResult ucResult;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelClientInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonCleaner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProductActivation;
        private System.Windows.Forms.Label labelTrialPeriodLeft;
    }
}