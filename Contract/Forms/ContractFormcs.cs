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
    public partial class ContractForm : DevExpress.XtraEditors.XtraForm
    {
        private DB.DBModel dbContext;
        private int contractID;

        public ContractForm(DB.DBModel dbContext)
        {
            InitializeComponent();

        }
        public ContractForm(DB.DBModel dbContext, int contractID)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.contractID = contractID;
            fillControls();
            fillExistingContract(contractID);

        }
        private void fillExistingContract(int id)
        {
            DB.Contract currContract = new DB.Contract();

            currContract = dbContext.Contract.Where(x => x.ID == id).ToList()[0];

            Text += currContract.Number + " от " + currContract.Date.ToString();

            tbContractNumber.Text = currContract.Number;
            tbContractNote.Text = currContract.Note;
            tbSumm.Text = currContract.Summ.ToString();
            tbContractTheme.Text = currContract.Theme;
            tbAuthor.Text = currContract.Users.Surname;

            deDate.DateTime = (DateTime)currContract.Date;
            deContractDateEnd.DateTime = (DateTime)currContract.EndDate;
            deContractDateStart.DateTime = (DateTime)currContract.StartDate;

            lueDepartment.Properties.DisplayMember = "Text";
            lueDepartment.Properties.ValueMember = "Value";
            lueDepartment.Properties.DataSource = dbContext.Departments.Select(x => new { Value = x.ID, Text = x.Name }).ToArray();
            lueDepartment.EditValue = currContract.DepartmentID;

            lueContractual.Properties.DisplayMember = "Text";
            lueContractual.Properties.ValueMember = "Value";
            lueContractual.Properties.DataSource = dbContext.Users.Select(x => new { Value = x.ID, Text = x.Surname + " " + x.FirstName.Substring(0,1) + "." + x.SecondName.Substring(0, 1) +"." }).ToArray();
            lueContractual.EditValue = currContract.ContractualID;

            lueExtensions.Properties.DisplayMember = "Text";
            lueExtensions.Properties.ValueMember = "Value";
            lueExtensions.Properties.DataSource = dbContext.ContractExtension.Select(x => new { Value = x.ID, Text = x.Name }).ToArray();
            lueExtensions.EditValue = currContract.ContractExtension;

            lueContractCategory.Properties.DisplayMember = "Text";
            lueContractCategory.Properties.ValueMember = "Value";
            lueContractCategory.Properties.DataSource = dbContext.ContractCategory.Select(x => new { Value = x.ID, Text = x.Name }).ToArray();
            lueContractCategory.EditValue = currContract.CategoryID;
        }
        private void fillControls()
        {


        }

        private void lueContractCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm("Category", dbContext);

                tmpForm.ShowDialog();
            }

        }

        private void lueDepartment_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm("Departments", dbContext);

                tmpForm.ShowDialog();
            }

        }

        private void lueContractual_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm("Users", dbContext);

                tmpForm.ShowDialog();
            }
        }
    }
}