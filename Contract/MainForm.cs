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
        private string currentUserLogin;
        private DBModel dbContext;
        private void initFormSettings()
        {
            dbContext = new DBModel();
        }

        public MainForm()
        {
            InitializeComponent();
            initFormSettings();

            //debug
            Forms.ContractForm tmpForm = new Forms.ContractForm(dbContext, 1, updateContracts);
            tmpForm.Show();

        }

        public MainForm(string userLogin)
        {
            InitializeComponent();
            initFormSettings();
            currentUserLogin = userLogin;
        }

        public void updateContracts()
        {
            var contractsBindingSource = dbContext.Contract.Select(x => new { x.ID, x.Number, x.ContractCategory.Name, x.Theme, x.Summ, x.Users.Surname }).ToList();
            gridControl1.DataSource = contractsBindingSource;
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
            var contractsBindingSource = dbContext.Contract.Select(x => new { x.ID, x.Number, x.ContractCategory.Name, x.Theme, x.Summ, x.Users.Surname}).ToList();
            gridControl1.DataSource = contractsBindingSource;
            gvContracts.Columns["ID"].Visible  = false;          
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
    }
}


//testestest