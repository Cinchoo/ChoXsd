using Cinchoo.Core;
using Cinchoo.Core.Configuration;
using Cinchoo.Core.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoXsd
{
    [ChoStandardAppSettingsConfigurationSection(Silent=false)]
    public class ChoAppSettings : ChoConfigurableObject
    {
        [ChoPropertyInfo("SDKDirectory", DefaultValue = @"C:\Program Files\Microsoft SDKs\Windows")]
        [ChoNotNullOrEmptyValidator]
        public string SDKDirectory;

        [ChoIgnoreProperty]
        public string XsdExeFilePath;

        protected override void OnAfterConfigurationObjectLoaded()
        {
            if (SDKDirectory.IsNullOrWhiteSpace())
                SDKDirectory = @"C:\Program Files\Microsoft SDKs\Windows";

            DirectoryInfo di = new DirectoryInfo(SDKDirectory);
            FileInfo[] files = null;

            try
            {
                files = di.GetFiles("xsd.exe", SearchOption.AllDirectories);
            }
            catch { }

            if (files != null && files.Length > 0)
                XsdExeFilePath = files[0].FullName;

            if (XsdExeFilePath.IsNullOrWhiteSpace())
                throw new ApplicationException("Xsd tool not found in '{0}' folder. Please install latest Microsoft SDK.".FormatString(SDKDirectory));

            if (!File.Exists(XsdExeFilePath))
                throw new ApplicationException("Specified Xsd tool '{0}' not found. Open App.config file, provide corrected path.".FormatString(XsdExeFilePath));
        }
    }
}
