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
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;

namespace Contract.Forms
{
    public partial class Authorization : DevExpress.XtraEditors.XtraForm
    {
        private DB.DBModel db;
        public Authorization()
        {
            InitializeComponent();
            
        }

        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            Authorize();
        }
        private void Authorize()
        {


            var fi = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
            fi.SetValue(ConfigurationManager.ConnectionStrings[1], false);
            ConfigurationManager.ConnectionStrings["DBModel"].ConnectionString = @"data source = 172.24.8.84\ZALUPAKITA; initial catalog = ContractBDTest; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework";

            db = new DB.DBModel();

            if (db.Users.Where(x => x.Login == tbLogin.Text && x.Password == tbPassword.Text).Count() > 0)
            {
                Properties.Settings.CurrentUserID = db.Users.Where(x => x.Login == tbLogin.Text).ToList()[0].ID;
                ParentForm main = new ParentForm();
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

        private void Authorization_Load(object sender, EventArgs e)
        {
            //test
        }
    }
}