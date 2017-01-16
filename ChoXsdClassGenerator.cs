using Cinchoo.Core;
using Cinchoo.Core.IO;
using Cinchoo.Core.Services;
using Cinchoo.Core.Shell;
using Cinchoo.Core.Windows.Forms;
using Cinchoo.Core.Xml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChoXsd
{
    public sealed class ChoXsdClassGenerator
    {
        public event EventHandler<ChoEventArgs<Tuple<int, string>>> Status;

        public bool Cancel
        {
            get;
            set;
        }

        public IChoAsyncResult GenerateAsync(ChoAsyncCallback callback = null)
        {
            return ChoQueuedExecutionService.Global.Enqueue(() =>
            {
                Generate();
            }, callback, null);
        }

        public void Generate()
        {
            string xmlTmpFilePath = null;
            try
            {
                ChoAppSettings appSettings = new ChoAppSettings();
                ChoAppCmdLineParams cmdLineArgs = new ChoAppCmdLineParams();

                ChoGuard.ArgumentNotNullOrEmpty(cmdLineArgs.XmlFilePath, "Xml File Path.");

                string xmlFilePath = Path.GetFullPath(cmdLineArgs.XmlFilePath);

                string outputDir = cmdLineArgs.OutputDirectory;

                if (outputDir.IsNullOrWhiteSpace())
                    outputDir = Path.GetDirectoryName(xmlFilePath);

                Directory.CreateDirectory(outputDir);

                ExpandIfXmlFile(ChoPath.GetFullPath(xmlFilePath), out xmlTmpFilePath);
                if (!xmlTmpFilePath.IsNullOrWhiteSpace())
                    xmlFilePath = xmlTmpFilePath;

                if (!File.Exists(xmlFilePath))
                    throw new ApplicationException("Xml '{0}' not found.".FormatString(xmlFilePath));

                RaiseSeriazliationStatus(0, "Generated files will be created in '{0}' directory...".FormatString(outputDir));

                CheckCancelRequested();

                StringBuilder cmdString = new StringBuilder(@"""{0}""".FormatString(xmlFilePath));
                if (cmdLineArgs.Classes)
                    cmdString.Append(" /c");
                if (cmdLineArgs.Dataset)
                    cmdString.Append(" /d");
                if (cmdLineArgs.Fields)
                    cmdString.Append(" /f");
                if (cmdLineArgs.Order)
                    cmdString.Append(" /order");
                if (cmdLineArgs.EnableLinqDataSet)
                    cmdString.Append(" /eld");
                if (cmdLineArgs.EnableDataBinding)
                    cmdString.Append(" /edb");
                if (!cmdLineArgs.Language.IsNullOrWhiteSpace())
                    cmdString.AppendFormat(" /l:{0}", cmdLineArgs.Language);
                if (!cmdLineArgs.Namespace.IsNullOrWhiteSpace())
                    cmdString.AppendFormat(" /n:{0}", cmdLineArgs.Namespace);
                if (!cmdLineArgs.Element.IsNullOrWhiteSpace())
                    cmdString.AppendFormat(" /e:{0}", cmdLineArgs.Element);
                if (!outputDir.IsNullOrWhiteSpace())
                    cmdString.AppendFormat(@" /o:""{0}""", outputDir);

                RaiseSeriazliationStatus(0, "{0}Generating classes...".FormatString(Environment.NewLine));
                CheckCancelRequested();
                Process process = new Process();
                var x = appSettings.XsdExeFilePath;
                process.StartInfo = new ProcessStartInfo(appSettings.XsdExeFilePath, cmdString.ToString());
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    RaiseSeriazliationStatus(0, result);
                }
                process.WaitForExit();

                if (process.ExitCode == 0)
                    RaiseSeriazliationStatus(0, "Generation of classes complete.");
                else
                    RaiseSeriazliationStatus(process.ExitCode, "Failed to generate of classes.");
            }
            catch (ChoCommandLineArgException)
            {
                throw;
            }
            catch (Exception ex)
            {
                RaiseSeriazliationStatus(-100, ChoApplicationException.ToString(ex));
            }
            finally
            {
                if (!xmlTmpFilePath.IsNullOrWhiteSpace())
                {
                    try
                    {
                        Directory.Delete(Path.GetDirectoryName(xmlTmpFilePath), true);
                    }
                    catch { }
                }
            }
        }

        private void ExpandIfXmlFile(string xmlFilePath, out string tmpFilePath)
        {
            tmpFilePath = null;

            string ext = Path.GetExtension(xmlFilePath);
            if (ext.IsNullOrWhiteSpace())
                return;

            if (String.Compare(ext, ".xml", true) != 0)
                return;

            string tmpDir = Path.Combine(Path.GetDirectoryName(xmlFilePath), Path.GetFileNameWithoutExtension(Path.GetRandomFileName()));
            Directory.CreateDirectory(tmpDir);

            tmpFilePath = Path.Combine(tmpDir, Path.GetFileName(xmlFilePath));

            //Expand and return new file
            using (ChoXmlDocument doc = new ChoXmlDocument(xmlFilePath))
            {
                File.WriteAllText(tmpFilePath, doc.XmlDocument.InnerXml);
            }
        }

        private void CheckCancelRequested()
        {
            if (Cancel)
                throw new ApplicationException("User cancelled the operation.");
        }

        private void RaiseSeriazliationStatus(int errorCode, string msg)
        {
            Status.Raise(null, new ChoEventArgs<Tuple<int, string>>(new Tuple<int,string>(errorCode, msg)));
        }
    }
}
