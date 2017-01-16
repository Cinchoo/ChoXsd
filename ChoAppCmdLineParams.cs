using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinchoo.Core;
using Cinchoo.Core.Shell;
using System.Windows.Forms;

namespace ChoXsd
{
    [ChoCommandLineArgObject(Description = "Utility to generate schema or class files from given source.")]
    public sealed class ChoAppCmdLineParams : ChoCommandLineArgObject
    {
        [ChoPositionalCommandLineArg(1, "xmlfile", IsRequired = true, Description = "Name of an xml file to infer xsd schema from.", Order = -1)]
        [ChoNotNullOrEmptyValidator]
        public string XmlFilePath
        {
            get;
            set;
        }

        [ChoCommandLineArg("o", Description = "The output directory to create files in. The default is the current directory.")]
        public string OutputDirectory
        {
            get;
            set;
        }

        [ChoCommandLineArg("c", Description = "Generate classes for this schema.")]
        public bool Classes
        {
            get;
            set;
        }

        [ChoCommandLineArg("d", Description = "Generate sub-classed DataSet for this schema.")]
        public bool Dataset
        {
            get;
            set;
        }

        [ChoCommandLineArg("eld", Description = "Generate LINQ-enabled sub-classed Dataset for the schemas provided.")]
        public bool EnableLinqDataSet
        {
            get;
            set;
        }

        [ChoCommandLineArg("e", Description = "Element from schema to process.")]
        public string Element
        {
            get;
            set;
        }

        [ChoCommandLineArg("f", Description = "Generate fields instead of properties.")]
        public bool Fields
        {
            get;
            set;
        }

        [ChoCommandLineArg("order", Description = "Generate explicit order identifiers on all particle members.")]
        public bool Order
        {
            get;
            set;
        }

        [ChoCommandLineArg("edb", Description = "Implement INotifyPropertyChanged interface on all generated types to enable data binding..")]
        public bool EnableDataBinding
        {
            get;
            set;
        }

        [ChoCommandLineArg("l", Description = "The language to use for the generated code. Choose from 'CS', 'VB', 'JS', 'VJS', 'CPP' or provide a fully-qualified name for a class implementing System.CodeDom.Compiler.CodeDomProvider. The default language is 'CS' (CSharp).")]
        public string Language
        {
            get;
            set;
        }

        [ChoCommandLineArg("n", Description = "The namespace for generated class files. The default namespace is the global namespace.")]
        public string Namespace
        {
            get;
            set;
        }

        protected override bool OnCommandLineArgLoadError(string memberName, object value, Exception ex)
        {
            if (ChoApplication.ApplicationMode == ChoApplicationMode.Windows)
                return true;
            else
                return false;
        }
    }
}
