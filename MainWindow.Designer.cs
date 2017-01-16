namespace ChoXsd
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEnableDataBinding = new System.Windows.Forms.CheckBox();
            this.chkOrder = new System.Windows.Forms.CheckBox();
            this.chkFields = new System.Windows.Forms.CheckBox();
            this.chkEnableLinqDataset = new System.Windows.Forms.CheckBox();
            this.chkDataset = new System.Windows.Forms.CheckBox();
            this.chkClasses = new System.Windows.Forms.CheckBox();
            this.btnSelectOutDirPath = new System.Windows.Forms.Button();
            this.btnSelectXmlFilePath = new System.Windows.Forms.Button();
            this.txtXmlFilePath = new System.Windows.Forms.TextBox();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.llblXsdHelp = new System.Windows.Forms.LinkLabel();
            this.ttApp = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnSelectOutDirPath);
            this.groupBox1.Controls.Add(this.btnSelectXmlFilePath);
            this.groupBox1.Controls.Add(this.txtXmlFilePath);
            this.groupBox1.Controls.Add(this.txtOutputDir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtElement);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtNamespace);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbLanguage);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.chkEnableDataBinding);
            this.groupBox3.Controls.Add(this.chkOrder);
            this.groupBox3.Controls.Add(this.chkFields);
            this.groupBox3.Controls.Add(this.chkEnableLinqDataset);
            this.groupBox3.Controls.Add(this.chkDataset);
            this.groupBox3.Controls.Add(this.chkClasses);
            this.groupBox3.Location = new System.Drawing.Point(8, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 70);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(510, 40);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(115, 20);
            this.txtElement.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Element:";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(349, 40);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(143, 20);
            this.txtNamespace.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Namespace:";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "CS",
            "VB",
            "JS",
            "VJS",
            "CPP"});
            this.cmbLanguage.Location = new System.Drawing.Point(349, 17);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(143, 21);
            this.cmbLanguage.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Language:";
            // 
            // chkEnableDataBinding
            // 
            this.chkEnableDataBinding.AutoSize = true;
            this.chkEnableDataBinding.Location = new System.Drawing.Point(151, 43);
            this.chkEnableDataBinding.Name = "chkEnableDataBinding";
            this.chkEnableDataBinding.Size = new System.Drawing.Size(123, 17);
            this.chkEnableDataBinding.TabIndex = 6;
            this.chkEnableDataBinding.Text = "Enable Data Binding";
            this.chkEnableDataBinding.UseVisualStyleBackColor = true;
            // 
            // chkOrder
            // 
            this.chkOrder.AutoSize = true;
            this.chkOrder.Location = new System.Drawing.Point(85, 43);
            this.chkOrder.Name = "chkOrder";
            this.chkOrder.Size = new System.Drawing.Size(52, 17);
            this.chkOrder.TabIndex = 5;
            this.chkOrder.Text = "Order";
            this.chkOrder.UseVisualStyleBackColor = true;
            // 
            // chkFields
            // 
            this.chkFields.AutoSize = true;
            this.chkFields.Location = new System.Drawing.Point(85, 20);
            this.chkFields.Name = "chkFields";
            this.chkFields.Size = new System.Drawing.Size(53, 17);
            this.chkFields.TabIndex = 4;
            this.chkFields.Text = "Fields";
            this.chkFields.UseVisualStyleBackColor = true;
            // 
            // chkEnableLinqDataset
            // 
            this.chkEnableLinqDataset.AutoSize = true;
            this.chkEnableLinqDataset.Location = new System.Drawing.Point(151, 20);
            this.chkEnableLinqDataset.Name = "chkEnableLinqDataset";
            this.chkEnableLinqDataset.Size = new System.Drawing.Size(122, 17);
            this.chkEnableLinqDataset.TabIndex = 3;
            this.chkEnableLinqDataset.Text = "Enable Linq Dataset";
            this.chkEnableLinqDataset.UseVisualStyleBackColor = true;
            // 
            // chkDataset
            // 
            this.chkDataset.AutoSize = true;
            this.chkDataset.Location = new System.Drawing.Point(12, 43);
            this.chkDataset.Name = "chkDataset";
            this.chkDataset.Size = new System.Drawing.Size(63, 17);
            this.chkDataset.TabIndex = 2;
            this.chkDataset.Text = "Dataset";
            this.chkDataset.UseVisualStyleBackColor = true;
            // 
            // chkClasses
            // 
            this.chkClasses.AutoSize = true;
            this.chkClasses.Location = new System.Drawing.Point(12, 20);
            this.chkClasses.Name = "chkClasses";
            this.chkClasses.Size = new System.Drawing.Size(62, 17);
            this.chkClasses.TabIndex = 1;
            this.chkClasses.Text = "Classes";
            this.chkClasses.UseVisualStyleBackColor = true;
            // 
            // btnSelectOutDirPath
            // 
            this.btnSelectOutDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectOutDirPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOutDirPath.Location = new System.Drawing.Point(620, 40);
            this.btnSelectOutDirPath.Name = "btnSelectOutDirPath";
            this.btnSelectOutDirPath.Size = new System.Drawing.Size(25, 23);
            this.btnSelectOutDirPath.TabIndex = 3;
            this.btnSelectOutDirPath.Text = "...";
            this.ttApp.SetToolTip(this.btnSelectOutDirPath, "Select destination directory...");
            this.btnSelectOutDirPath.UseVisualStyleBackColor = true;
            this.btnSelectOutDirPath.Click += new System.EventHandler(this.btnSelectOurDirPath_Click);
            // 
            // btnSelectXmlFilePath
            // 
            this.btnSelectXmlFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectXmlFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectXmlFilePath.Location = new System.Drawing.Point(620, 15);
            this.btnSelectXmlFilePath.Name = "btnSelectXmlFilePath";
            this.btnSelectXmlFilePath.Size = new System.Drawing.Size(25, 23);
            this.btnSelectXmlFilePath.TabIndex = 1;
            this.btnSelectXmlFilePath.Text = "...";
            this.ttApp.SetToolTip(this.btnSelectXmlFilePath, "Choose Xml file...");
            this.btnSelectXmlFilePath.UseVisualStyleBackColor = true;
            this.btnSelectXmlFilePath.Click += new System.EventHandler(this.btnSelectXmlFilePath_Click);
            // 
            // txtXmlFilePath
            // 
            this.txtXmlFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXmlFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXmlFilePath.Location = new System.Drawing.Point(100, 16);
            this.txtXmlFilePath.Name = "txtXmlFilePath";
            this.txtXmlFilePath.Size = new System.Drawing.Size(512, 20);
            this.txtXmlFilePath.TabIndex = 0;
            this.ttApp.SetToolTip(this.txtXmlFilePath, "Xml File Path");
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutputDir.Location = new System.Drawing.Point(100, 41);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(512, 20);
            this.txtOutputDir.TabIndex = 2;
            this.ttApp.SetToolTip(this.txtOutputDir, "Output directory");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xml File Path:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(4, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Location = new System.Drawing.Point(3, 16);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(642, 193);
            this.txtStatus.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(499, 373);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(580, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Enabled = false;
            this.lblVersion.Location = new System.Drawing.Point(4, 378);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 2;
            // 
            // llblXsdHelp
            // 
            this.llblXsdHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llblXsdHelp.AutoSize = true;
            this.llblXsdHelp.Location = new System.Drawing.Point(97, 378);
            this.llblXsdHelp.Name = "llblXsdHelp";
            this.llblXsdHelp.Size = new System.Drawing.Size(88, 13);
            this.llblXsdHelp.TabIndex = 3;
            this.llblXsdHelp.TabStop = true;
            this.llblXsdHelp.Text = "Xsd.exe tool help";
            this.llblXsdHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblXsdHelp_LinkClicked);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 404);
            this.Controls.Add(this.llblXsdHelp);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "XSD GUI Tool - Cinchoo Inc.";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectXmlFilePath;
        private System.Windows.Forms.TextBox txtXmlFilePath;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectOutDirPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkEnableDataBinding;
        private System.Windows.Forms.CheckBox chkOrder;
        private System.Windows.Forms.CheckBox chkFields;
        private System.Windows.Forms.CheckBox chkEnableLinqDataset;
        private System.Windows.Forms.CheckBox chkDataset;
        private System.Windows.Forms.CheckBox chkClasses;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llblXsdHelp;
        private System.Windows.Forms.ToolTip ttApp;
    }
}

