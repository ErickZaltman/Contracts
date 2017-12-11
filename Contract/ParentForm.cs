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
        }

        public void updateContracts()
        {
            Forms.ContractSelectForm childForm = (xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractSelectForm);
            childForm.gridControl1.DataSource = null;
            childForm.gridControl1.MainView = childForm.gvList;

            var contractsBindingSource = dbContext.Contract.Where(y => y.isRemoved != true).Join(dbContext.getFullUserName, e => e.AuthorID, x => x.ID, (e, x) => new
            {
                e.ID,
                e.Number,
                Category = e.ContractCategory.Name,
                e.Theme,
                e.Summ,
                Name = x.FullName
            }).ToList();

            childForm.gridControl1.DataSource = contractsBindingSource;

            childForm.gvList.Columns["ID"].Visible = false;

            childForm.gvList.Columns["Number"].Caption = "Номер договора";
            childForm.gvList.Columns["Category"].Caption = "Категория договора";
            childForm.gvList.Columns["Theme"].Caption = "Предмет договора";
            childForm.gvList.Columns["Summ"].Caption = "Сумма договора";
            childForm.gvList.Columns["Name"].Caption = "Автор";
        }

        #region Ribbon OPEN forms buttons click
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
        #endregion

        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            // if (xtraTabbedMdiManager1.Pages.Count > 1 && (xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractForm) || xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractSelectForm)))
            if (xtraTabbedMdiManager1.SelectedPage != null && (xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractForm) || xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractSelectForm)))

            {
                rpContractWork.Visible = true;
            }
            else
                rpContractWork.Visible = false;
        }     

        private void bbtnRemoveContract_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm childForm = (xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractSelectForm);
            int rowIndex = childForm.gvList.GetSelectedRows()[0];
            int id = Convert.ToInt32(childForm.gvList.GetRowCellValue(rowIndex, "ID"));
            childForm.RemoveContract(id);
            updateContracts();
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {

        }
    }
    
}

// Тут была ЗЛАЯЛЕЗБУХА