using System;
using System.Threading;
using System.Windows.Forms;
using QLSV.App.Helpers;
using QLSV.Core.Helpers;

namespace QLSV.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += OnThreadException;
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;

            try
            {
                var login = new frmLogin();
                Application.Run(login);
            }
            catch (Exception ex)
            {
                Err.GhiLog(ex, "Lỗi khởi chạy ứng dụng");
                Announce.Error(Err.GiaiThich(ex));
            }
        }

        private static void OnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Err.GhiLog(e.Exception, "UI thread exception");
            Announce.Error(Err.GiaiThich(e.Exception));
        }

        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception ?? new Exception("Unknown unhandled exception.");
            Err.GhiLog(ex, "Unhandled exception");
            Announce.Error(Err.GiaiThich(ex));
        }
    }
}
