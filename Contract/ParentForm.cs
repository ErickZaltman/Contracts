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


            

            
        }

        private void tsmiMainForm_Click(object sender, EventArgs e)
        {
            MainForm tmpForm = new MainForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }

        private void bbrnContracts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm tmpForm = new Forms.ContractSelectForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }

        private void bbtnSingingDocs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SigningSelectForm tmpForm = new Forms.SigningSelectForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractorsSelectForm tmpForm = new Forms.ContractorsSelectForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SupAgreementsSelectForm tmpForm = new Forms.SupAgreementsSelectForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }

        private void bbtnAnexes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.AnnexesSelectForm tmpForm = new Forms.AnnexesSelectForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }

        private void bbtnDisAgreements_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bbtnDepartments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DepartmentsSelectForm tmpForm = new Forms.DepartmentsSelectForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }

        private void bbtnActivityKind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ActivityKindsSelectForm tmpForm = new Forms.ActivityKindsSelectForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }

        private void ParentForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                MessageBox.Show("");
        }
    }
    
}

// 11:39