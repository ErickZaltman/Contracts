using Contract.DB;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contract
{
    public delegate void UpdateContracts();
    
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private DBModel dbContext;

        private int getIntPermission(Permissions prm)
        {
            return Int32.Parse(prm.ToString("d"));
        }
        private void checkPermissions(int userID)
        {
            int tmpInt = getIntPermission(Permissions.Signing);

            
        }

        public MainForm()
        {
            InitializeComponent();
            dbContext = new DBModel();
            
            checkPermissions(Properties.Settings.CurrentUserID);
        }


        #region Договора
        public void updateContracts()
        {
            gcMain.DataSource = null;
            gcMain.MainView = gvContracts;

            var contractsBindingSource = dbContext.Contracts.Select(x => new
            {
                x.ID,
                x.Number,
                Category = x.ContractCategory.Name,
                x.Theme,
                x.Summ,
                Name = x.Users.Surname + " " + x.Users.FirstName.Substring(0, 1) + "." + x.Users.SecondName.Substring(0, 1) + "."
            }).ToList();
            gcMain.DataSource = contractsBindingSource;

            gvContracts.Columns["ID"].Visible = false;

            gvContracts.Columns["Number"].Caption = "Номер договора";
            gvContracts.Columns["Category"].Caption = "Категория договора";
            gvContracts.Columns["Theme"].Caption = "Предмет договора";
            gvContracts.Columns["Summ"].Caption = "Сумма договора";
            gvContracts.Columns["Name"].Caption = "Автор";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void nbiContracts_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            updateContracts();                  
        }

        private void gvContracts_RowClick(object sender, RowClickEventArgs e)
        {
            //if (e.Clicks > 1)
            //{
            //    Forms.ContractForm tmpForm = new Forms.ContractForm((int)gvContracts.GetRowCellValue(e.RowHandle, "ID"), string.Empty, updateContracts);
            //    tmpForm.MdiParent = ParentForm;
            //    tmpForm.Show();
            //}      
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Forms.ContractForm tmpForm = new Forms.ContractForm(0, "?????username??????", updateContracts);
            //tmpForm.MdiParent = ParentForm;
            //tmpForm.Show();
        }

        #endregion

        #region Соглашения
        private void nbiSigningDocs_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            updateSignings();
        }

        private void updateSignings()
        {
            gcMain.DataSource = null;
            gcMain.MainView = gvSignings;
            var contractsBindingSource = dbContext.Signing.Where(x => x.UserID == Properties.Settings.CurrentUserID).Select(x => new {
                x.ID,
                x.ContractID,
                x.Contracts.Number,
                x.Contracts.Theme,
                Name = x.Contracts.Users.Surname + " " + x.Contracts.Users.FirstName.Substring(0, 1) + "." + x.Contracts.Users.SecondName.Substring(0, 1) + ".",
                x.IsAgreed
            }).ToList();
            gcMain.DataSource = contractsBindingSource;
            
            gvSignings.Columns["ID"].Visible = false;
            gvSignings.Columns["ContractID"].Visible = false;
            gvSignings.Columns["IsAgreed"].Caption = "Согласовано";
            gvSignings.Columns["Number"].Caption = "Номер договора";
            gvSignings.Columns["Theme"].Caption = "Предмет договора";
            gvSignings.Columns["Name"].Caption = "Автор";
        }

        private void updateSupAgreements()
        {
            gcMain.DataSource = null;
            gcMain.MainView = gvSupAgreements;
            var contractsBindingSource = dbContext.SupAgreement.Select(x => new {
                x.ID,
                x.ContractID,
                x.Contracts.Number,
                x.Contracts.Theme,
                Name = x.Contracts.Users.Surname + " " + x.Contracts.Users.FirstName.Substring(0, 1) + "." + x.Contracts.Users.SecondName.Substring(0, 1) + "."
            }).ToList();
            gcMain.DataSource = contractsBindingSource;

            gvSupAgreements.Columns["ID"].Visible = false;
            gvSupAgreements.Columns["ContractID"].Visible = false;
            gvSupAgreements.Columns["Number"].Caption = "Номер договора";
            gvSupAgreements.Columns["Theme"].Caption = "Предмет договора";
            gvSupAgreements.Columns["Name"].Caption = "Автор";
        }

        private void updateAnnexes()
        {
            gcMain.DataSource = null;
            gcMain.MainView = gvAnnexes;
            var contractsBindingSource = dbContext.ContractAnnex.Select(x => new {
                x.ID,
                x.ContractID,
                x.Contracts.Number,
                x.Contracts.Theme,
                annexType = x.AnnexTypes.Name,
                x.ActionDate,
                Name = x.Contracts.Users.Surname + " " + x.Contracts.Users.FirstName.Substring(0, 1) + "." + x.Contracts.Users.SecondName.Substring(0, 1) + "."
            }).ToList();
            gcMain.DataSource = contractsBindingSource;

            gvAnnexes.Columns["ID"].Visible = false;
            gvAnnexes.Columns["ContractID"].Visible = false;
            gvAnnexes.Columns["Number"].Caption = "Номер договора";
            gvAnnexes.Columns["Theme"].Caption = "Предмет договора";
            gvAnnexes.Columns["Name"].Caption = "Автор";
            gvAnnexes.Columns["annexType"].Caption = "Вид приложения";

        }


        private void gvAgreements_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Clicks > 1)
            {
                Forms.SigningForm tmpForm = new Forms.SigningForm((int)gvSignings.GetRowCellValue(e.RowHandle,"ID"));
                tmpForm.MdiParent = ParentForm;
                tmpForm.Show();
            }
        }

        #endregion


        private void nbiContractors_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.SelectForm tmpForm = new Forms.SelectForm(Tables.Contractors);
            tmpForm.MdiParent = ParentForm;
            tmpForm.Show();
        }

        private void nbiDepartments_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.SelectForm tmpForm = new Forms.SelectForm(Tables.Departments);
            tmpForm.MdiParent = ParentForm;
            tmpForm.Show();
        }

        private void nbiActivityKinds_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.SelectForm tmpForm = new Forms.SelectForm(Tables.ActivityKinds);
            tmpForm.MdiParent = ParentForm;
            tmpForm.Show();
        }

        private void nbiSupAgreements_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            updateSupAgreements();
        }

        private void nbiAnnexes_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            updateAnnexes();
        }

        private void gvSupAgreements_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Clicks > 1)
            {
                Forms.SupAgreementForm tmpForm = new Forms.SupAgreementForm((int)gvSupAgreements.GetRowCellValue(e.RowHandle, "ID"));
                tmpForm.MdiParent = ParentForm;
                tmpForm.Show();
            }
        }

        private void gvAnnexes_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Clicks > 1)
            {
                Forms.ContractAnnexForm tmpForm = new Forms.ContractAnnexForm((int)gvAnnexes.GetRowCellValue(e.RowHandle, "ID"));
                tmpForm.MdiParent = ParentForm;
                tmpForm.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}


//123
//456