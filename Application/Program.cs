using System;
using System.Threading;
using System.Windows.Forms;
using QLSV.App.Helpers;

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
                Announce.ErrorDatabase(ex);
            }
        }

        private static void OnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Announce.ErrorDatabase(e.Exception);
        }

        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception ?? new Exception("Lỗi không xác định từ hệ thống.");
            Announce.ErrorDatabase(ex);
        }
    }
}
