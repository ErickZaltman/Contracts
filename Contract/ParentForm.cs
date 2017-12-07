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
using Contract.DB;

namespace Contract
{
    public partial class ParentForm : DevExpress.XtraEditors.XtraForm
    {

        ////TODO 
        //Придумать кнопки

        DBModel dbContext;

        public ParentForm()
        {
            InitializeComponent();
        }

        public ParentForm(int id)
        {
            InitializeComponent();

            dbContext = new DBModel();
            Properties.Settings.CurrentUserID = id;

            tsslblCurrentUserName.Text = dbContext.Users.Where(y => y.ID == Properties.Settings.CurrentUserID).Select(x => new {
                Name = x.Surname + " " + x.FirstName.Substring(0, 1) + ". "
                + x.SecondName.Substring(0, 1) + "."
            }).ToList()[0].Name;

            MainForm tmpForm = new MainForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }

        private void tsmiMainForm_Click(object sender, EventArgs e)
        {
            MainForm tmpForm = new MainForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }
    }
}

// 11:36