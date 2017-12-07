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

       

        public ParentForm()
        {
            InitializeComponent();
        }
        DBModel dbContext;
        public ParentForm(int id)
        {
            InitializeComponent();

            dbContext = new DBModel();
            Properties.Settings.CurrentUserID = id;

            

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

// 11:39