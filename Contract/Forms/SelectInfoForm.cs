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

namespace Contract.Forms
{
    public partial class SelectInfoForm : DevExpress.XtraEditors.XtraForm
    {
        private string type;
        private Tables table;
        private DB.DBModel dbContext;

        private getIDFromForm d;
 
        public SelectInfoForm(Tables table, DB.DBModel dbContext, getIDFromForm sender)
        {
            InitializeComponent();
            this.Text = type;
            d = sender;
            this.table = table;
            this.dbContext = dbContext;
            FillGV();
        }

        private void FillGV()
        {
            switch (this.table)
            {
                case Tables.Category: FillGVCategory(); Text = "Выберите категорию"; break;
                case Tables.Users: FillGVUsers(); Text = ":"; break;
                case Tables.Departments: FillGVDepartments(); Text = ":"; break;
                case Tables.Contractors: FillGVContractors(); Text = ":"; break;
                case Tables.ActivityKinds: FillGVActivityKinds(); Text = ":"; break;

                default: MessageBox.Show("Y"); break;
            }
        }

        private void FillGVCategory()
        {
            gridControl1.DataSource = dbContext.ContractCategory.Select(x => new { x.ID, x.Name }).ToList();
            gridView1.Columns["ID"].Visible = false;
        }

        private void FillGVUsers()
        {
            gridControl1.DataSource = dbContext.Users.Select(x => new {x.ID, Name =  x.Surname +  " " +  x.FirstName.Substring(0,1) + ". " + x.SecondName.Substring(0, 1) + "." }).ToList();
            gridView1.Columns["ID"].Visible = false;
        }
        private void FillGVDepartments()
        {
            gridControl1.DataSource = dbContext.Departments.Select(x => new { x.ID, x.Name }).ToList();
            gridView1.Columns["ID"].Visible = false;
        }

        private void FillGVContractors()
        {
            gridControl1.DataSource = dbContext.Contractors.Select(x => new { x.ID, x.Name }).ToList();
            gridView1.Columns["ID"].Visible = false;
        }

        private void FillGVActivityKinds()
        {
            gridControl1.DataSource = dbContext.ActivityKind.Select(x => new { x.ID, x.Name }).ToList();
            gridView1.Columns["ID"].Visible = false;
        }
        public SelectInfoForm()
        {
            InitializeComponent();
        }

        private void SelectInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks > 1)
            {
                d((int)gridView1.GetRowCellValue(e.RowHandle, "ID"),table);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}