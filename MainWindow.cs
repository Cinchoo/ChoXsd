using Cinchoo.Core;
using Cinchoo.Core.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoXsd
{
    public partial class MainWindow : Form
    {
        private ChoXsdClassGenerator _xsdClassGenerator;
        private StringBuilder _statusMsg = new StringBuilder();

        public MainWindow()
        {
            InitializeComponent();
            lblVersion.Text = "v{0}".FormatString(Assembly.GetExecutingAssembly().GetName().Version.ToString());
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void btnSelectXmlFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Xml Files (*.xml)|*.xml|All Files|*.*";
            dlg.FilterIndex = 1;
            dlg.Multiselect = false;

            DialogResult result = dlg.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK)
                return;

            txtXmlFilePath.Text = dlg.FileName;
        }

        private void btnSelectOurDirPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            DialogResult result = dlg.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK)
                return;

            txtOutputDir.Text = dlg.SelectedPath;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            btnCancel.Enabled = true;

            _statusMsg.Clear();
            txtStatus.Text = String.Empty;

            ChoAppCmdLineParams appCmdLineParams = new ChoAppCmdLineParams();
            _xsdClassGenerator = new ChoXsdClassGenerator();
            _xsdClassGenerator.Status += xmlSerializerAssemblyCreator_SerializationStatus;
            _xsdClassGenerator.GenerateAsync(
                (result) =>
                {
                    result.EndInvoke();

                    this.BeginInvoke((Action)delegate()
                    {
                        btnGenerate.Enabled = true;
                        btnCancel.Enabled = false;
                    });
                });
        }

        void xmlSerializerAssemblyCreator_SerializationStatus(object sender, Cinchoo.Core.ChoEventArgs<Tuple<int, string>> e)
        {
            this.BeginInvoke((Action)delegate()
                {
                    string msg = e.Value.Item2;
                    if (e.Value.Item1 != 0)
                        msg += "{1}(ErrCode: {0})".FormatString(e.Value.Item1, Environment.NewLine);

                    if (txtStatus.Text.Length == 0)
                        txtStatus.Text += msg;
                    else
                        txtStatus.Text += Environment.NewLine + msg;

                    txtStatus.SelectionStart = txtStatus.Text.Length;
                    txtStatus.ScrollToCaret();
                });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChoXsdClassGenerator xsdClassGenerator = _xsdClassGenerator;

            if (xsdClassGenerator != null)
                xsdClassGenerator.Cancel = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            txtXmlFilePath.Select();
            llblXsdHelp.Links.Add(0, llblXsdHelp.Text.Length, "https://www.google.com/search?q=Xsd.exe");

            ChoAppCmdLineParams cmdLineParams = new ChoAppCmdLineParams();
            
            BindingList<BindingClass> list = new BindingList<BindingClass>();
            list.Add(new BindingClass { Name = "CS" });
            list.Add(new BindingClass { Name = "VB" });
            list.Add(new BindingClass { Name = "CPP" });
            list.Add(new BindingClass { Name = "JS" });
            list.Add(new BindingClass { Name = "VJS" });

            cmbLanguage.DataSource = list;
            cmbLanguage.DisplayMember = "Name";
            cmbLanguage.ValueMember = "Name";
            cmbLanguage.DataBindings.Add("SelectedValue",
                cmdLineParams,
                "Language",
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            txtXmlFilePath.DataBindings.Add("Text",
                                            cmdLineParams,
                                            "XmlFilePath",
                                            false,
                                            DataSourceUpdateMode.OnPropertyChanged);
            txtOutputDir.DataBindings.Add("Text",
                                     cmdLineParams,
                                     "OutputDirectory",
                                     false,
                                     DataSourceUpdateMode.OnPropertyChanged);
            chkClasses.DataBindings.Add("Checked",
                                     cmdLineParams,
                                     "Classes",
                                     false,
                                     DataSourceUpdateMode.OnPropertyChanged);
            chkDataset.DataBindings.Add("Checked",
                                     cmdLineParams,
                                     "Dataset",
                                     false,
                                     DataSourceUpdateMode.OnPropertyChanged);
            chkFields.DataBindings.Add("Checked",
                             cmdLineParams,
                             "Fields",
                             false,
                             DataSourceUpdateMode.OnPropertyChanged);
            chkOrder.DataBindings.Add("Checked",
                     cmdLineParams,
                     "Order",
                     false,
                     DataSourceUpdateMode.OnPropertyChanged);
            chkEnableLinqDataset.DataBindings.Add("Checked",
                     cmdLineParams,
                     "EnableLinqDataset",
                     false,
                     DataSourceUpdateMode.OnPropertyChanged);
            chkEnableDataBinding.DataBindings.Add("Checked",
                     cmdLineParams,
                     "EnableDataBinding",
                     false,
                     DataSourceUpdateMode.OnPropertyChanged);
            txtNamespace.DataBindings.Add("Text",
                cmdLineParams,
                "Namespace",
                false,
                DataSourceUpdateMode.OnPropertyChanged);
            txtElement.DataBindings.Add("Text",
                cmdLineParams,
                "Element",
                false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        public class BindingClass
        {
            public string Name { get; set; }
        }

        private void llblXsdHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
