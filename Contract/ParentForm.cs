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
using System.Configuration;

namespace Contract
{
    public partial class ParentForm : DevExpress.XtraEditors.XtraForm
    {
        DBModel dbContext;
        private DocumentFormsContainer documentManager;

        internal DocumentFormsContainer DocumentManager
        {
            get
            {
                return documentManager;
            }

            set
            {
                documentManager = value;
            }
        }

        public ParentForm()
        {
            InitializeComponent();
            documentManager = new DocumentFormsContainer();

        }
        public ParentForm(int id)
        {
            InitializeComponent();

            dbContext = new DBModel();
            Properties.Settings.CurrentUserID = id;
            documentManager = new DocumentFormsContainer();

        }

        #region Update Grid Controls
        public void updateContracts()
        {
            Forms.ContractSelectForm childForm = new Forms.ContractSelectForm();
            foreach(var item in this.MdiChildren)
            {
                if(item is Forms.ContractSelectForm)
                {
                    childForm = item as Forms.ContractSelectForm;
                    break;
                }
            }

            childForm.gridControl1.DataSource = null;
            childForm.gridControl1.MainView = childForm.gvList;

            var contractsBindingSource = dbContext.Contract.Where(y => y.IsRemoved != true).Join(dbContext.getFullUserName, e => e.AuthorID, x => x.ID, (e, x) => new
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

        public void updateContractors()
        {
            Forms.ContractorsSelectForm childForm = new Forms.ContractorsSelectForm();
            foreach (var item in this.MdiChildren)
            {
                if (item is Forms.ContractorsSelectForm)
                {
                    childForm = item as Forms.ContractorsSelectForm;
                    break;
                }
            }

            childForm.gridControl1.DataSource = null;
            childForm.gridControl1.MainView = childForm.gvList;

            var contractsBindingSource = dbContext.Contractors.Where(y => y.IsRemoved != true).Select(x => new
            {
                ID = x.ID,
                Name = x.Name
            }).ToList();

            childForm.gridControl1.DataSource = contractsBindingSource;

            childForm.gvList.Columns["ID"].Visible = false;

            childForm.gvList.Columns["Name"].Caption = "Наименование";
        }

        #endregion

        #region Ribbon OPEN forms buttons click
        private void bbrnContracts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm tmpForm = Forms.ContractSelectForm.getInst();
            tmpForm.MdiParent = this;
            tmpForm.Show();

            xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[tmpForm];
            rpContractWork.Visible = true;
            ribbonControl1.SelectedPage = rpContractWork;

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

            rpContractors.Visible = true;
            ribbonControl1.SelectedPage = rpContractors;
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
            if (xtraTabbedMdiManager1.SelectedPage != null && (xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractForm) || xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractSelectForm)))
            {
                rpContractWork.Visible = true;
                if ((xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractForm)))
                {
                    bbtnNewContract.Enabled = false;
                    bbtnRemoveContract.Enabled = false;
                    bbtnSendToSigning.Enabled = true;
                    bbtnConnectedDocs.Enabled = true;
                    bbtnAttachments.Enabled = true;
                }
                else
                {
                    bbtnNewContract.Enabled = true;
                    bbtnRemoveContract.Enabled = true;
                    bbtnSendToSigning.Enabled = false;
                    bbtnConnectedDocs.Enabled = false;
                    bbtnAttachments.Enabled = false;
                }
            }
            else
                rpContractWork.Visible = false;

            if (xtraTabbedMdiManager1.SelectedPage != null && (xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractorForm) || xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractorsSelectForm)))
            {
                rpContractors.Visible = true;
                if ((xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractorForm)))
                {
                    bbtnNewContractor.Enabled = false;
                    bbtnRemoveContractor.Enabled = false;
                    bbtnSaveContractor.Enabled = true;
                }
                else
                {
                    bbtnNewContractor.Enabled = true;
                    bbtnRemoveContractor.Enabled = true;
                    bbtnSaveContractor.Enabled = false;
                }
            }
            else
                rpContractors.Visible = false;

            if (xtraTabbedMdiManager1.Pages.Count > 0) barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }     

        private void bbtnRemoveContract_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm childForm = (xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractSelectForm);
            int rowIndex = childForm.gvList.GetSelectedRows()[0];
            int id = Convert.ToInt32(childForm.gvList.GetRowCellValue(rowIndex, "ID"));
            childForm.RemoveContract(id);
            updateContracts();

            DB.ContractMovements movements = new DB.ContractMovements();
            movements.ContractID = id;
            movements.Date = DateTime.Now;
            movements.AuthorID = Properties.Settings.CurrentUserID;
            movements.MovementTypeID = 3;
            dbContext.ContractMovements.Add(movements);
            dbContext.SaveChanges();
        }

        private void bbtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractForm childForm = (xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractForm);
            if (childForm.IsValid())
            {
                childForm.SaveContracChanges();
                updateContracts();
                bbtnSave.Enabled = false;
            }
        }

        private void bbtnSendToSigning_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractForm childForm = (xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractForm);
            childForm.SaveContracChanges();
            childForm.SendContractToSigning();
            childForm.FillAgreemenst();
        }

        private void bbtnNewContract_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbtnSave.Enabled = true;
            var tmpform = new Forms.ContractForm(0);
            tmpform.MdiParent = this;
            tmpform.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                xtraTabbedMdiManager1.SelectedPage.MdiChild.Close();
            if (xtraTabbedMdiManager1.Pages.Count == 0) barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            


        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            documentManager.removePage(e.Page.MdiChild);
        }

        private void bbtnNewContractor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbtnSaveContractor.Enabled = true;
            var tmpform = new Forms.ContractorForm(0);
            tmpform.MdiParent = this;
            tmpform.Show();
        }

        private void bbtnRemoveContractor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractorsSelectForm childForm = (xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractorsSelectForm);
            int rowIndex = childForm.gvList.GetSelectedRows()[0];
            int id = Convert.ToInt32(childForm.gvList.GetRowCellValue(rowIndex, "ID"));
            //childForm.RemoveContractor(id);
            updateContractors();
        }

        private void bbtnSaveContractor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractorForm childForm = (xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractorForm);
            if (childForm.IsValid())
            {
                childForm.SaveContractorChanges();
                updateContractors();
                xtraTabbedMdiManager1.SelectedPage.Text = childForm.GetName();
                bbtnSaveContractor.Enabled = false;
            }
        }
        private void bbtnContractWordDocument_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WordDocument wd = new WordDocument();
            wd.makeNewWordContract((xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractForm).currContract);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(ConfigurationManager.ConnectionStrings["DBModel"].ToString());
        }
    }
    
}