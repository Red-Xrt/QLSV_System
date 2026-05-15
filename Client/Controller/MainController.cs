using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Controller
{
    public static class MainController
    {
        private static Form frmdangmo;
        public static void FrmCon(Form frmcon, string title, Panel vitri, Label tieude)
        {
            if (frmdangmo != null)
            {
                frmdangmo.Close();
            }

            frmdangmo = frmcon;
            frmcon.TopLevel = false;
            frmcon.FormBorderStyle = FormBorderStyle.None;
            frmcon.Dock = DockStyle.Fill;

            vitri.Controls.Add(frmcon);
            vitri.Tag = frmcon;
            tieude.Text = title;

            frmcon.BringToFront();
            frmcon.Show();
        }
    }
}
