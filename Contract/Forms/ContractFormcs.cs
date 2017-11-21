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
    public delegate void getIDFromForm(int ID, string type);
    public partial class ContractForm : DevExpress.XtraEditors.XtraForm
    {
        private int returnID;
        private DB.DBModel dbContext;
        private int contractID;
        private DB.Contract currContract;

        public int ReturnID
        {
            get
            {
                return returnID;
            }

            set
            {
                returnID = value;
            }
        }

        public ContractForm(DB.DBModel dbContext)
        {
            InitializeComponent();
            fillControls();

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
            currContract = new DB.Contract();
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

            lueDepartment.EditValue = currContract.DepartmentID;
            lueContractual.EditValue = currContract.ContractualID;
            lueExtensions.EditValue = currContract.ContractExtensionID;
            lueExtensionPeriod.EditValue = currContract.ContractExtensionTimeID;
            lueContractCategory.EditValue = currContract.CategoryID;
            lueActivityKind.EditValue = currContract.ActivityKindID;
            lueContractors.EditValue = currContract.ContractorID;
        }
        private void fillControls()
        {
            lueDepartment.Properties.DisplayMember = "Text";
            lueDepartment.Properties.ValueMember = "Value";
            lueDepartment.Properties.DataSource = dbContext.Departments.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

            lueContractual.Properties.DisplayMember = "Text";
            lueContractual.Properties.ValueMember = "Value";
            lueContractual.Properties.DataSource = dbContext.Users.Select(x => new { Value = x.ID, Text = x.Surname + " " + x.FirstName.Substring(0, 1) + "." + x.SecondName.Substring(0, 1) + "." }).ToList();

            lueExtensions.Properties.DisplayMember = "Text";
            lueExtensions.Properties.ValueMember = "Value";
            lueExtensions.Properties.DataSource = dbContext.ContractExtension.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

            lueExtensionPeriod.Properties.DisplayMember = "Text";
            lueExtensionPeriod.Properties.ValueMember = "Value";
            lueExtensionPeriod.Properties.DataSource = dbContext.ContractExtensionPeriod.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

            lueContractCategory.Properties.DisplayMember = "Text";
            lueContractCategory.Properties.ValueMember = "Value";
            lueContractCategory.Properties.DataSource = dbContext.ContractCategory.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

            lueContractors.Properties.DisplayMember = "Text";
            lueContractors.Properties.ValueMember = "Value";
            lueContractors.Properties.DataSource = dbContext.Contractors.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

            lueActivityKind.Properties.DisplayMember = "Text";
            lueActivityKind.Properties.ValueMember = "Value";
            lueActivityKind.Properties.DataSource = dbContext.ActivityKind.Select(x => new { Value = x.ID, Text = x.Name }).ToList();
        }
        private void getID(int ID, string type)
        {
            switch (type)
            {
                case "Category": lueContractCategory.EditValue = ID; break;
                case "Users": lueContractual.EditValue = ID; break;
                case "Departments": lueDepartment.EditValue = ID; break;

            }
        }

        private void lueContractCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm("Category", dbContext, getID);

                tmpForm.ShowDialog();
            }

        }
        

        private void lueDepartment_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm("Departments", dbContext, getID);

                tmpForm.ShowDialog();
            }

        }

        private void lueContractual_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm("Users", dbContext, getID);

                tmpForm.ShowDialog();
            }
        }

        private void sbSaveChanges_Click(object sender, EventArgs e)
        {
            if (lueContractCategory.Text != "" && currContract.CategoryID != (int)lueContractCategory.EditValue)
                currContract.CategoryID = (int)lueContractCategory.EditValue;
            if (lueDepartment.Text != "" && currContract.DepartmentID != (int)lueDepartment.EditValue)
                currContract.DepartmentID = (int)lueDepartment.EditValue;
            if (lueContractual.Text != "" && currContract.ContractualID != (int)lueContractual.EditValue)
                currContract.ContractualID = (int)lueContractual.EditValue;
            if (lueActivityKind.Text != "" && currContract.ActivityKindID != (int)lueActivityKind.EditValue)
                currContract.ActivityKindID = (int)lueActivityKind.EditValue;
            if (lueExtensions.Text != "" && currContract.ContractExtensionID != (int)lueExtensions.EditValue)
                currContract.ContractExtensionID = (int)lueExtensions.EditValue;
            if (lueExtensionPeriod.Text != "" && currContract.ContractExtensionTimeID != (int)lueExtensionPeriod.EditValue)
                currContract.ContractExtensionTimeID = (int)lueExtensionPeriod.EditValue;
            if (tbSumm.Text != "" && currContract.Summ != Convert.ToDouble(tbSumm.Text))
                currContract.Summ = Convert.ToDouble(tbSumm.Text);

            dbContext.SaveChanges();
        }

        private void lueContractors_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm("Contractors", dbContext, getID);

                tmpForm.ShowDialog();
            }
        }
    }
}