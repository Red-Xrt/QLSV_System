using System.Windows.Forms;

namespace QLSV.App.Controllers
{
    public static class MainController
    {
        private static Form _formDangMo;

        public static void FrmCon(Form frmcon, string title, Panel vitri, Label tieude)
        {
            if (_formDangMo != null)
            {
                vitri.Controls.Remove(_formDangMo);
                _formDangMo.Dispose();
                _formDangMo = null;
            }

            _formDangMo = frmcon;
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
