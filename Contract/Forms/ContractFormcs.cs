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

            lueDepartment.EditValue = currContract.DepartmentID;
            lueContractual.EditValue = currContract.ContractualID;
            lueExtensions.EditValue = currContract.ContractExtension;
            lueExtensionPeriod.EditValue = currContract.ContractExtensionTime;
            lueContractCategory.EditValue = currContract.CategoryID;
            lueActivityKind.EditValue = currContract.ActivityKindID;
        }
        private void fillControls()
        {
            lueDepartment.Properties.DisplayMember = "Text";
            lueDepartment.Properties.ValueMember = "Value";
            lueDepartment.Properties.DataSource = dbContext.Departments.Select(x => new { Value = x.ID, Text = x.Name }).ToArray();

            lueContractual.Properties.DisplayMember = "Text";
            lueContractual.Properties.ValueMember = "Value";
            lueContractual.Properties.DataSource = dbContext.Users.Select(x => new { Value = x.ID, Text = x.Surname + " " + x.FirstName.Substring(0, 1) + "." + x.SecondName.Substring(0, 1) + "." }).ToArray();

            lueExtensions.Properties.DisplayMember = "Text";
            lueExtensions.Properties.ValueMember = "Value";
            lueExtensions.Properties.DataSource = dbContext.ContractExtension.Select(x => new { Value = x.ID, Text = x.Name }).ToArray();

            lueExtensionPeriod.Properties.DisplayMember = "Text";
            lueExtensionPeriod.Properties.ValueMember = "Value";
            lueExtensionPeriod.Properties.DataSource = dbContext.ContractExtensionPeriod.Select(x => new { Value = x.ID, Text = x.Name }).ToArray();

            lueContractCategory.Properties.DisplayMember = "Text";
            lueContractCategory.Properties.ValueMember = "Value";
            lueContractCategory.Properties.DataSource = dbContext.ContractCategory.Select(x => new { Value = x.ID, Text = x.Name }).ToArray();

            lueActivityKind.Properties.DisplayMember = "Text";
            lueActivityKind.Properties.ValueMember = "Value";
            lueActivityKind.Properties.DataSource = dbContext.ActivityKind.Select(x => new { Value = x.ID, Text = x.Name }).ToArray();

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
    }
}