using System;
using System.Windows.Forms;

namespace QLSV.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var login = new frmLogin();
            Application.Run(login);
        }
    }
}
