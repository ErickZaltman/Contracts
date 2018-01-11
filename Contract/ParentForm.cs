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
using DevExpress.XtraGrid.Columns;

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
            dbContext = new DBModel();

            documentManager = new DocumentFormsContainer();
            bsiUserName.Caption = dbContext.getFullUserName.First(x => x.ID == Properties.Settings.CurrentUserID).FullName;
        }
        public ParentForm(int id)
        {
            InitializeComponent();

            dbContext = new DBModel();
            Properties.Settings.CurrentUserID = id;
            documentManager = new DocumentFormsContainer();

            bsiUserName.Caption = dbContext.getFullUserName.First(x => x.ID == Properties.Settings.CurrentUserID).FullName;

            repositoryItemLueFilterField.DataSource = new List<string> { "Номер договора" };
            repositoryItemLueFilterMethod.DataSource = new List<string> { "Равно", "Не равно", "Содержит" };
            repositoryItemLueSortField.DataSource = new List<string> { "Номер договора" };
            repositoryItemLueSortMethod.DataSource = new List<string> { "По возрастанию", "По убыванию" };


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

            var contractsBindingSource = dbContext.Contracts.Where(y => y.IsRemoved != true).Join(dbContext.getFullUserName, e => e.AuthorID, x => x.ID, (e, x) => new
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
                    rpgContracts.Visible = false;
                    rpgContractsFilter.Visible = false;
                    rpgContractsSort.Visible = false;
                    rpgContractWork.Visible = true;
                    rpgContractsSettings.Visible = false;
                    if ((xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractForm).currentID == 0 || (xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractForm).DataChanged() == false)
                        bbtnSave.Enabled = true;
                    else
                        bbtnSave.Enabled = false;
                }
                else
                {
                    rpgContracts.Visible = true;
                    rpgContractsFilter.Visible = true;
                    rpgContractsSort.Visible = true;
                    rpgContractWork.Visible = false;
                    rpgContractsSettings.Visible = true;
                }
            }
            else
                rpContractWork.Visible = false;

            if (xtraTabbedMdiManager1.SelectedPage != null && (xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractorForm) || xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractorsSelectForm)))
            {
                rpContractors.Visible = true;
                if ((xtraTabbedMdiManager1.SelectedPage.MdiChild.GetType() == typeof(Forms.ContractorForm)))
                {
                    rpgContractor.Visible = false;
                    rpgContractorWork.Visible = true;

                    if ((xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractorForm).currentID == 0 || (xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractorForm).DataChanged() == false)
                        bbtnSaveContractor.Enabled = true;
                    else
                        bbtnSaveContractor.Enabled = false;
                }
                else
                {
                    rpgContractor.Visible = true;
                    rpgContractorWork.Visible = false;
                }
            }
            else
                rpContractors.Visible = false;

            if (xtraTabbedMdiManager1.Pages.Count > 0) barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        #region Ribbon Current Contract Page



        #endregion

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
            childForm.RemoveContractor(id);
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

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(Application.OpenForms.Count.ToString());
        }

        private void bbtnOpenContract_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm childForm = (xtraTabbedMdiManager1.SelectedPage.MdiChild as Forms.ContractSelectForm);
            int rowIndex = childForm.gvList.GetSelectedRows()[0];
            int id = Convert.ToInt32(childForm.gvList.GetRowCellValue(rowIndex, "ID"));
            Forms.ContractForm form = new Forms.ContractForm(id);
            form.MdiParent = this;
            form.Show();
        }

        private void bbtnUpdateContracts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            updateContracts();
        }

        private void bbiFilter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FilterContracts();
        }

        private void FilterContracts()
        {
            if (beiFilterValue.EditValue != null && beiFilterField.EditValue != null && beiFilterMethod.EditValue != null)
            {
                Forms.ContractSelectForm childForm = new Forms.ContractSelectForm();
                foreach (var item in this.MdiChildren)
                {
                    if (item is Forms.ContractSelectForm)
                    {
                        childForm = item as Forms.ContractSelectForm;
                        break;
                    }
                }
                string filterString = string.Empty;
                string filterField = string.Empty;
                string filterValue = beiFilterValue.EditValue.ToString();
                switch (beiFilterField.EditValue.ToString())
                {
                    case "Номер договора": filterField = "Number"; break;
                }

                switch (beiFilterMethod.EditValue.ToString())
                {
                    case "Содержит": filterString = "Contains([" + filterField + "], '" + filterValue + "')"; break;
                    case "Равно": filterString = "[" + filterField + "]='" + filterValue + "'"; break;
                    case "Не равно": filterString = "[" + filterField + "]!='" + filterValue + "'"; break;
                }


                childForm.gvList.ActiveFilterString = filterString;
                childForm.gvList.ApplyColumnsFilter();
            }
        }

        private void bbiFilterClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm childForm = new Forms.ContractSelectForm();
            foreach (var item in this.MdiChildren)
            {
                if (item is Forms.ContractSelectForm)
                {
                    childForm = item as Forms.ContractSelectForm;
                    break;
                }
            }
            childForm.gvList.ClearColumnsFilter();
        }

        private void bbiFilterCreator_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm childForm = new Forms.ContractSelectForm();
            foreach (var item in this.MdiChildren)
            {
                if (item is Forms.ContractSelectForm)
                {
                    childForm = item as Forms.ContractSelectForm;
                    break;
                }
            }
            childForm.gvList.ShowFilterEditor(null);
        }

        private void bbiSort_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SortContracts();
        }

        public void SortContracts()
        {
            if (beiSortField.EditValue != null && beiSortMethod.EditValue != null)
            {
                Forms.ContractSelectForm childForm = new Forms.ContractSelectForm();
                foreach (var item in this.MdiChildren)
                {
                    if (item is Forms.ContractSelectForm)
                    {
                        childForm = item as Forms.ContractSelectForm;
                        break;
                    }
                }

                string sortField = string.Empty;
                DevExpress.Data.ColumnSortOrder method = new DevExpress.Data.ColumnSortOrder();
                if (beiSortMethod.EditValue.ToString() == "По возрастанию")
                    method = DevExpress.Data.ColumnSortOrder.Ascending;
                else
                    method = DevExpress.Data.ColumnSortOrder.Descending;
                switch (beiSortField.EditValue.ToString())
                {
                    case "Номер договора": sortField = "Number"; break;
                }
                childForm.gvList.SortInfo.ClearAndAddRange(new[] {
                    new GridColumnSortInfo(childForm.gvList.Columns[sortField], method)
                });

            }
        }

        private void bbiRemoveSort_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm childForm = new Forms.ContractSelectForm();
            foreach (var item in this.MdiChildren)
            {
                if (item is Forms.ContractSelectForm)
                {
                    childForm = item as Forms.ContractSelectForm;
                    break;
                }
            }
            childForm.gvList.ClearSorting();
        }

        private void bbiAutoWidth_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm childForm = new Forms.ContractSelectForm();
            foreach (var item in this.MdiChildren)
            {
                if (item is Forms.ContractSelectForm)
                {
                    childForm = item as Forms.ContractSelectForm;
                    break;
                }
            }
            childForm.gvList.BestFitColumns();
        }

        private void bciFindString_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm childForm = new Forms.ContractSelectForm();
            foreach (var item in this.MdiChildren)
            {
                if (item is Forms.ContractSelectForm)
                {
                    childForm = item as Forms.ContractSelectForm;
                    break;
                }
            }
            if (bciFindString.Checked)
                childForm.gvList.ShowFindPanel();
            else
                childForm.gvList.HideFindPanel();
        }

        private void bciAutoFilterPanel_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.ContractSelectForm childForm = new Forms.ContractSelectForm();
            foreach (var item in this.MdiChildren)
            {
                if (item is Forms.ContractSelectForm)
                {
                    childForm = item as Forms.ContractSelectForm;
                    break;
                }
            }
            if (bciAutoFilterPanel.Checked)
                childForm.gvList.OptionsView.ShowAutoFilterRow = true;
            else
                childForm.gvList.OptionsView.ShowAutoFilterRow = false;
        }

    }  
}

