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
        private void initFormSettings()
        {
            dbContext = new DBModel();
            tsslUserName.Text = dbContext.Users.Where(y => y.ID == Properties.Settings.CurrentUserID).Select(x => new { Name = x.Surname + " " + x.FirstName.Substring(0, 1) + ". " 
                + x.SecondName.Substring(0, 1) + "." }).ToList()[0].Name;
        }

        public MainForm()
        {
            InitializeComponent();
            initFormSettings();

            //debug
            

        }

        public MainForm(int userID)
        {
            InitializeComponent();
            Properties.Settings.CurrentUserID = userID;
            initFormSettings();

        }

        public void updateContracts()
        {
            gridControl1.DataSource = null;
            gridControl1.MainView = gvContracts;


            var contractsBindingSource = dbContext.Contract.Select(x => new
            {
                x.ID,
                x.Number,
                Category = x.ContractCategory.Name,
                x.Theme,
                x.Summ,
                Name = x.Users.Surname + " " + x.Users.FirstName.Substring(0, 1) + "." + x.Users.SecondName.Substring(0, 1) + "."
            }).ToList();
            gridControl1.DataSource = contractsBindingSource;

            gvContracts.Columns["ID"].Visible = false;

            gvContracts.Columns["Number"].Caption = "Номер договора";
            gvContracts.Columns["Category"].Caption = "Категория договора";
            gvContracts.Columns["Theme"].Caption = "Предмет договора";
            gvContracts.Columns["Summ"].Caption = "Сумма договора";
            gvContracts.Columns["Name"].Caption = "Автор";

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nbiContracts_ItemChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void nbiContracts_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            updateContracts();                  
        }

        private void gvContracts_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show( ((GridView)sender).GetSelectedRows()[0].ToString() );
            
        }

        private void gvContracts_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Clicks > 1)
            {
                Forms.ContractForm tmpForm = new Forms.ContractForm(dbContext, (int)gvContracts.GetRowCellValue(e.RowHandle, "ID"), updateContracts);
                tmpForm.Show();
            }      
        }

        private void nbiAgreementsDocs_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            updateAgreements();

        }

        private void updateAgreements()
        {
            gridControl1.DataSource = null;
            gridControl1.MainView = gvAgreements;
            var contractsBindingSource = dbContext.Signing.Where(x => x.UserID == Properties.Settings.CurrentUserID).Select(x => new {
                x.ID,
                x.ContractID,
                x.Contract.Number,
                x.Contract.Theme,
                Name = x.Contract.Users.Surname + " " + x.Contract.Users.FirstName.Substring(0, 1) + "." + x.Contract.Users.SecondName.Substring(0, 1) + ".",
                x.IsAgreed
            }).ToList();
            gridControl1.DataSource = contractsBindingSource;
            
            gvAgreements.Columns["ID"].Visible = false;
            gvAgreements.Columns["ContractID"].Visible = false;
            gvAgreements.Columns["IsAgreed"].Caption = "Согласовано";
            gvAgreements.Columns["Number"].Caption = "Номер договора";
            gvAgreements.Columns["Theme"].Caption = "Предмет договора";
            gvAgreements.Columns["Name"].Caption = "Автор";





        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Forms.ContractForm tmpForm = new Forms.ContractForm(dbContext,0, updateContracts);
            tmpForm.Show();
        }

        private void gvAgreements_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Clicks > 1)
            {
                Forms.SigningForm tmpForm = new Forms.SigningForm(dbContext, (int)gvAgreements.GetRowCellValue(e.RowHandle,"ID"), (int)gvAgreements.GetRowCellValue(e.RowHandle, "ContractID"), updateAgreements);
                tmpForm.Show();
            }
        }

        
    }
}


//zzazzaz