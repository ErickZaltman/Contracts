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
        private DB.DBModel dbContext;
        public SelectInfoForm(string type, DB.DBModel dbContext)
        {
            
            InitializeComponent();
            this.Text = type;
            this.type = type;
            this.dbContext = dbContext;
            FillGV();
        }


        private void FillGV()
        {
            switch (this.type)
            {
                case "Category": FillGVCategory(); Text = "Выберите категорию"; break;
                case "Users": FillGVUsers(); Text = ":"; break;
                case "Departments": FillGVDepartments(); Text = ":"; break;

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
            //gridControl1.DataSource = dbContext.Users.Select(x => new {x.ID, Name =  x.Surname + " " + x.FirstName[0] + ". " + x.SecondName[0]+ "."}).ToList();
            gridView1.Columns["ID"].Visible = false;
        }
        private void FillGVDepartments()
        {
            gridControl1.DataSource = dbContext.Departments.Select(x => new { x.ID, x.Name }).ToList();
            gridView1.Columns["ID"].Visible = false;
        }
        public SelectInfoForm()
        {
            InitializeComponent();
        }
    }
}