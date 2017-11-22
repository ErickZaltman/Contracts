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
    public delegate void getIDFromForm(int ID, Tables type);
    public partial class ContractForm : DevExpress.XtraEditors.XtraForm
    {
        private int returnID;
        private DB.DBModel dbContext;
        private int contractID;
        private DB.Contract currContract;

        private UpdateContracts uc;

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

        
        public ContractForm(DB.DBModel dbContext, int contractID, UpdateContracts updateContracts)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.contractID = contractID;
            this.uc = updateContracts;
            fillControls();
            
            if (contractID == 0)
            {
                currContract = new DB.Contract();
            }else
            {
                fillExistingContract(contractID);
            }

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

            if (currContract.Date != null)
                deDate.DateTime = (DateTime)currContract.Date;
            if (currContract.EndDate != null)
                deContractDateEnd.DateTime = (DateTime)currContract.EndDate;
            if (currContract.StartDate != null)
                deContractDateStart.DateTime = (DateTime)currContract.StartDate;

            lueDepartment.EditValue = currContract.DepartmentID;
            lueContractual.EditValue = currContract.ContractualID;
            lueExtensions.EditValue = currContract.ContractExtensionID;
            lueExtensionPeriod.EditValue = currContract.ContractExtensionTimeID;
            lueContractCategory.EditValue = currContract.CategoryID;
            lueActivityKind.EditValue = currContract.ActivityKindID;
            lueContractors.EditValue = currContract.ContractorID;


            if(currContract.OnAgreement == true)
            {
                FillAgreemenst();
            }
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
        private void getIDSelectedItemID(int ID, Tables type)
        {
            switch (type)
            {
                case Tables.Category: lueContractCategory.EditValue = ID; break;
                case Tables.Users: lueContractual.EditValue = ID; break;
                case Tables.Departments: lueDepartment.EditValue = ID; break;
                case Tables.ActivityKinds: lueActivityKind.EditValue = ID; break;
                case Tables.Contractors: lueContractors.EditValue = ID; break;

            }
        }

        private void lueContractCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm(Tables.Category, dbContext, getIDSelectedItemID);

                tmpForm.ShowDialog();
            }

        }
        

        private void lueDepartment_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm(Tables.Departments, dbContext, getIDSelectedItemID);

                tmpForm.ShowDialog();
            }

        }

        private void lueContractual_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm(Tables.Users, dbContext, getIDSelectedItemID);

                tmpForm.ShowDialog();
            }
        }

        private void sbSaveChanges_Click(object sender, EventArgs e)
        {
            SaveContracChanges();
        }


        private void checkNullLUE()
        {
            foreach(var tmpLue in Controls)
            {
                if (tmpLue.GetType() == typeof(LookUpEdit))
                {
                    MessageBox.Show((tmpLue as LookUpEdit).Name + ";" + (tmpLue as LookUpEdit).EditValue);
                }
            }
            foreach (var tmpLue in tnpMainInfo.Controls)
            {
                if (tmpLue.GetType() == typeof(LookUpEdit))
                {
                    MessageBox.Show((tmpLue as LookUpEdit).Name + ";" + (tmpLue as LookUpEdit).EditValue);
                }
            }
        }
        private void SaveContracChanges()
        {
            if (lueContractCategory.Text != "" && lueContractCategory.EditValue!= null && currContract.CategoryID != (int)lueContractCategory.EditValue)
                currContract.CategoryID = (int)lueContractCategory.EditValue;
            if (lueDepartment.Text != "" && lueDepartment.EditValue != null && currContract.DepartmentID != (int)lueDepartment.EditValue)
                currContract.DepartmentID = (int)lueDepartment.EditValue;
            if (lueContractual.Text != "" && lueContractual.EditValue != null && currContract.ContractualID != (int)lueContractual.EditValue)
                currContract.ContractualID = (int)lueContractual.EditValue;
            if (lueActivityKind.Text != "" && lueActivityKind.EditValue != null && currContract.ActivityKindID != (int)lueActivityKind.EditValue)
                currContract.ActivityKindID = (int)lueActivityKind.EditValue;
            if (lueExtensions.Text != "" && lueExtensions.EditValue != null && currContract.ContractExtensionID != (int)lueExtensions.EditValue)
                currContract.ContractExtensionID = (int)lueExtensions.EditValue;
            if (lueContractors.Text != "" && lueContractors.EditValue != null && currContract.ContractorID != (int)lueContractors.EditValue)
                currContract.ContractorID = (int)lueContractors.EditValue;
            if (lueExtensionPeriod.Text != "" && lueExtensionPeriod.EditValue != null && currContract.ContractExtensionTimeID != (int)lueExtensionPeriod.EditValue)
                currContract.ContractExtensionTimeID = (int)lueExtensionPeriod.EditValue;
            if (tbSumm.Text != "" && currContract.Summ != Convert.ToDouble(tbSumm.Text))
                currContract.Summ = Convert.ToDouble(tbSumm.Text);
            if (tbContractNote.Text != "" && currContract.Note != tbContractNote.Text)
                currContract.Note = tbContractNote.Text;
            if (tbContractTheme.Text != "" && currContract.Theme != tbContractTheme.Text)
                currContract.Theme = tbContractTheme.Text;

            if (deDate.Text == "")
                currContract.Date = null;
            else
                if (currContract.Date != Convert.ToDateTime(deDate.Text))
                currContract.Date = Convert.ToDateTime(deDate.Text);

            if (deContractDateEnd.Text == "")
                currContract.EndDate = null;
            else
                if (currContract.EndDate != Convert.ToDateTime(deContractDateEnd.Text))
                currContract.EndDate = Convert.ToDateTime(deContractDateEnd.Text);

            if (deContractDateStart.Text == "")
                currContract.StartDate = null;
            else
                if (currContract.StartDate != Convert.ToDateTime(deContractDateStart.Text))
                currContract.StartDate = Convert.ToDateTime(deContractDateStart.Text);

            if(this.contractID == 0)
            {
                dbContext.Contract.Add(currContract);
                contractID = currContract.ID;

            }
            dbContext.SaveChanges();
            uc();
        }

        private void lueContractors_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm(Tables.Contractors, dbContext, getIDSelectedItemID);

                tmpForm.ShowDialog();
            }
        }

        private void lueActivityKind_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectInfoForm tmpForm = new SelectInfoForm(Tables.ActivityKinds, dbContext, getIDSelectedItemID);

                tmpForm.ShowDialog();
            }
        }

        private void SendContractToSigning()
        {

            foreach (var user in dbContext.AgreementSignList.Select(x => x.ID).ToList())
            {
                DB.Signing tmpSigning = new DB.Signing();
                tmpSigning.UserID = user;
                tmpSigning.ContractID = currContract.ID;
                tmpSigning.DeadlineTime = DateTime.Now.AddDays(5);
                tmpSigning.IsAgreed = false;
                dbContext.Signing.Add(tmpSigning);
                
            }
            dbContext.SaveChanges();
        }

        private void FillAgreemenst()
        {
            gcAgreements.DataSource = dbContext.Signing.Where(x => x.ContractID == currContract.ID).ToList();
            gvAgreements.Columns["ID"].Visible = false;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveContracChanges();

            currContract.OnAgreement = true;
            SendContractToSigning();

            FillAgreemenst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkNullLUE();
        }
    }
}

//fggfgffggf