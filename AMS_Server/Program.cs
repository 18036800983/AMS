using AMS_Server.FormTool;
using AMS_Server.FromMain;
using DevComponents.DotNetBar;
using Server_Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_Server
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createNew;
            using (Mutex mutex = GetMutex(out createNew))
            {
                if (createNew)
                {
#if !DEBUG
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
#endif
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    if (XML_Tool.xml.SysConfig.StartWithLogin)
                    {
                        LoginForm loginForm = new LoginForm();
                        if (loginForm.ShowDialog() != DialogResult.OK)
                        {
                            Application.Run(new MainForm());
                        }
                    }
                    else
                    {
                        Application.Run(new MainForm());
                    }
                }
                else
                {
                    MessageBoxEx.Show("应用程序已经在运行中...");
                    Thread.Sleep(1000);
                    Environment.Exit(1);
                }
            }
        }

        private static Mutex GetMutex(out bool createNew)
        {
            return new Mutex(true, Application.ProductName, out createNew);
        }
    }
}
