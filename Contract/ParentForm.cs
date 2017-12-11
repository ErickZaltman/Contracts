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


        private void setActiveForm(Type formType)
        {
        }

        private void tsmiMainForm_Click(object sender, EventArgs e)
        {
            MainForm tmpForm = new MainForm();
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }

        private void bbrnContracts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm tmpForm = (Forms.ContractSelectForm)Forms.ContractSelectForm.getInst();
            tmpForm.MdiParent = this;
            tmpForm.Show();

            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[tmpForm];

        }

        private void bbtnSingingDocs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SigningSelectForm tmpForm = Forms.SigningSelectForm.getInst() as Forms.SigningSelectForm;
            tmpForm.MdiParent = this;
            tmpForm.Show();
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[tmpForm];
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractorsSelectForm tmpForm = Forms.ContractorsSelectForm.getInst();
            tmpForm.MdiParent = this;
            tmpForm.Show();
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[tmpForm];
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.SupAgreementsSelectForm tmpForm = Forms.SupAgreementsSelectForm.getInst() as Forms.SupAgreementsSelectForm;
            tmpForm.MdiParent = this;
            tmpForm.Show();
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[tmpForm];
        }

        private void bbtnAnexes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.AnnexesSelectForm tmpForm = Forms.AnnexesSelectForm.getInst() as Forms.AnnexesSelectForm;
            tmpForm.MdiParent = this;
            tmpForm.Show();
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[tmpForm];
        }

        private void bbtnDisAgreements_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bbtnDepartments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.DepartmentsSelectForm tmpForm = Forms.DepartmentsSelectForm.getInst() as Forms.DepartmentsSelectForm;
            tmpForm.MdiParent = this;
            tmpForm.Show();
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[tmpForm];
        }

        private void bbtnActivityKind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ActivityKindsSelectForm tmpForm =  Forms.ActivityKindsSelectForm.getInst() as Forms.ActivityKindsSelectForm;
            tmpForm.MdiParent = this;
            tmpForm.Show();
            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[tmpForm];
        }

        private void ParentForm_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (xtraTabbedMdiManager1.Pages.Count > 1 && (xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractForm) || xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractSelectForm)))
            {
                rpContractWork.Visible = true;
            }
            else
                rpContractWork.Visible = false;
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int i = 0;
        }
    }
    
}

// 11:39