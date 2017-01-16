using Cinchoo.Core;
using Cinchoo.Core.Diagnostics;
using Cinchoo.Core.Shell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoXsd
{
    [ChoApplicationHost]
    public partial class ApplicationHost : ChoApplicationHost
    {
        private Lazy<MainWindow> _window = new Lazy<MainWindow>(() => new MainWindow());

        protected override void OnStart(string[] args)
        {
            if (ChoApplication.ApplicationMode == ChoApplicationMode.Console)
            {
                    ChoAppCmdLineParams appCmdLineParams = new ChoAppCmdLineParams();
                    ChoXsdClassGenerator xsdClassGenerator = new ChoXsdClassGenerator();
                    xsdClassGenerator.Status += (o, e) =>
                    {
                        string msg = e.Value.Item2;
                        if (e.Value.Item1 != 0)
                            msg += Environment.NewLine + "(ErrCode: {0})".FormatString(e.Value.Item1);

                        Console.WriteLine(msg);
                    };
                    xsdClassGenerator.Generate();
            }
            else
                base.OnStart(args);
        }
    
        public override object MainWindowObject
        {
            get
            {
                return _window.Value;
            }
        }

        protected override void ApplyGlobalApplicationSettingsOverrides(ChoGlobalApplicationSettings obj)
        {
            obj.ApplicationBehaviourSettings.SingleInstanceApp = false;
            obj.TrayApplicationBehaviourSettings.TurnOn = ChoApplication.ApplicationMode != ChoApplicationMode.Console;
            obj.TrayApplicationBehaviourSettings.ContextMenuSettings.DisplayShowMainWndMenuItem = true;
            obj.TrayApplicationBehaviourSettings.ContextMenuSettings.DisplayAboutMenuItem = false;
            obj.TrayApplicationBehaviourSettings.ContextMenuSettings.DisplayHelpMenuItem = false;
            obj.TrayApplicationBehaviourSettings.TurnOnMode = ChoTrayAppTurnOnMode.OnMinimize;
            obj.TrayApplicationBehaviourSettings.TooltipText = "XSD GUI Tool";
            obj.TrayApplicationBehaviourSettings.BalloonTipText = "XSD GUI tool is still running...";

        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ChoTraceSwitch.Switch.Level = TraceLevel.Off;
            ChoApplication.Run(args);
        }
    }
}
