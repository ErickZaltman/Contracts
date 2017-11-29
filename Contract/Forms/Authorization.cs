using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Contract.Forms
{
    public partial class Authorization : DevExpress.XtraEditors.XtraForm
    {
        private DB.DBModel db;
        public Authorization()
        {
            InitializeComponent();

            db = new DB.DBModel();
        }

        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            Authorize();
        }
        private void Authorize()
        {
            if (db.Users.Where(x => x.Login == tbLogin.Text && x.Password == tbPassword.Text).Count() > 0)
            {
                Properties.Settings.CurrentUserID = db.Users.Where(x => x.Login == tbLogin.Text).ToList()[0].ID;
                MainForm main = new MainForm();
                main.Show();
                Hide();
                
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                Authorize();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Authorize();
            }
        }
    }
}