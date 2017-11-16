using Contract.DB;
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
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private string currentUserLogin;
        private DBModel dbContext;
        private void initFormSettings()
        {
            dbContext = new DBModel();
            dbContext.Database.Initialize(false);
            dbContext.Contract.Load();


        }
        public MainForm()
        {
            initFormSettings();
            InitializeComponent();
            


        }
        public MainForm(string userLogin)
        {
            initFormSettings();
            InitializeComponent();
            currentUserLogin = userLogin;
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nbiContracts_ItemChanged(object sender, EventArgs e)
        {
            var contractsBindingSource = dbContext.Contract.Select(x => new { x.ID, x.Number, x.CategoryID }).ToList();
            gridControl1.DataSource = contractsBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}




