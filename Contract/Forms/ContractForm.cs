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
        private DB.DBModel dbContext;
        private int contractID;
        private string UserName;
        private bool isLoaded = false;
        
        private DB.Contract currContract;

        private UpdateContracts uc;
        
        public ContractForm(int contractID, string UserName, UpdateContracts updateContracts)
        {
            BaseEdit.DefaultErrorIconAlignment = ErrorIconAlignment.BottomRight;

            InitializeComponent();
            dbContext = new DB.DBModel();
            
            this.contractID = contractID;
            this.UserName = UserName;
            this.uc = updateContracts;
            fillControls();

            currContract = new DB.Contract();
            if (contractID != 0)
                fillExistingContract(contractID);

            if (contractID == 0)
            {
                sbSaveChanges.Enabled = true;
                teAuthor.Text = UserName;
            }

            if (contractID != 0)
                Text = "Договор № " + currContract.Number + " от " + String.Format("{0:dd/MM/yyyy}", currContract.Date);
            else
                Text = "Новый договор";
        }

        private void fillExistingContract(int id)
        {
            currContract = dbContext.Contract.Where(x => x.ID == id).ToList()[0];

            teContractNumber.Text = currContract.Number;
            teContractNote.Text = currContract.Note;
            teSumm.Text = currContract.Summ.ToString();
            teContractTheme.Text = currContract.Theme;
            teAuthor.Text = currContract.Users.Surname + " " + currContract.Users.FirstName.Substring(0, 1) + "." + currContract.Users.SecondName.Substring(0, 1) + ".";

            if (currContract.Date != null)
                deDate.DateTime = (DateTime)currContract.Date;
            if (currContract.EndDate != null)
                deContractDateEnd.DateTime = (DateTime)currContract.EndDate;
            if (currContract.StartDate != null)
                deContractDateStart.DateTime = (DateTime)currContract.StartDate;
            if (currContract.ConclusionDate != null)
                deConclusionDate.DateTime = (DateTime)currContract.ConclusionDate;

            lueDepartment.EditValue = currContract.DepartmentID;
            lueContractual.EditValue = currContract.ContractualID;
            lueExtensions.EditValue = currContract.ContractRenewalID;
            lueContractCategory.EditValue = currContract.CategoryID;
            lueContractors.EditValue = currContract.ContractorID;


            if(currContract.OnAgreement == true)
            {
                FillAgreemenst();
            }

            isLoaded = true;
        }

        #region  LookUpEdits

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
            lueExtensions.Properties.DataSource = dbContext.ContractRenewal.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

            lueContractCategory.Properties.DisplayMember = "Text";
            lueContractCategory.Properties.ValueMember = "Value";
            lueContractCategory.Properties.DataSource = dbContext.ContractCategory.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

            lueContractors.Properties.DisplayMember = "Text";
            lueContractors.Properties.ValueMember = "Value";
            lueContractors.Properties.DataSource = dbContext.Contractors.Select(x => new { Value = x.ID, Text = x.Name }).ToList();
        }
        private void getIDSelectedItemID(int ID, Tables type)
        {
            switch (type)
            {
                case Tables.Category: lueContractCategory.EditValue = ID; break;
                case Tables.Users: lueContractual.EditValue = ID; break;
                case Tables.Departments: lueDepartment.EditValue = ID; break;
                case Tables.Contractors: lueContractors.EditValue = ID; break;
            }
        }
        private void lueContractCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectForm tmpForm = new SelectForm(Tables.Category, true, getIDSelectedItemID);

                tmpForm.ShowDialog();
            }
        }
        private void lueDepartment_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectForm tmpForm = new SelectForm(Tables.Departments, true, getIDSelectedItemID);

                tmpForm.ShowDialog();
            }

        }
        private void lueContractual_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectForm tmpForm = new SelectForm(Tables.Users, true, getIDSelectedItemID);

                tmpForm.ShowDialog();
            }
        }
        private void lueContractors_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectForm tmpForm = new SelectForm(Tables.Contractors, true, getIDSelectedItemID);

                tmpForm.ShowDialog();
            }
        }
        private void lueActivityKind_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                Forms.SelectForm tmpForm = new SelectForm(Tables.ActivityKinds, true, getIDSelectedItemID);

                tmpForm.ShowDialog();
            }
        }
        #endregion

        #region SaveChanges
        private void SaveContracChanges()
        {
            if (lueContractCategory.Text != "" && lueContractCategory.EditValue!= null && currContract.CategoryID != (int)lueContractCategory.EditValue)
                currContract.CategoryID = (int)lueContractCategory.EditValue;
            if (lueDepartment.Text != "" && lueDepartment.EditValue != null && currContract.DepartmentID != (int)lueDepartment.EditValue)
                currContract.DepartmentID = (int)lueDepartment.EditValue;
            if (lueContractual.Text != "" && lueContractual.EditValue != null && currContract.ContractualID != (int)lueContractual.EditValue)
                currContract.ContractualID = (int)lueContractual.EditValue;
            if (lueExtensions.Text != "" && lueExtensions.EditValue != null && currContract.ContractRenewalID != (int)lueExtensions.EditValue)
                currContract.ContractRenewalID = (int)lueExtensions.EditValue;
            if (lueContractors.Text != "" && lueContractors.EditValue != null && currContract.ContractorID != (int)lueContractors.EditValue)
                currContract.ContractorID = (int)lueContractors.EditValue;
            if (teSumm.Text != "" && currContract.Summ != Convert.ToDouble(teSumm.Text))
                currContract.Summ = Convert.ToDouble(teSumm.Text);
            else if (teSumm.Text == "")
                currContract.Summ = null;

            if (teContractNote.Text == "")
                currContract.Note = null;
            else
                if (currContract.Note != teContractNote.Text)
                    currContract.Note = teContractNote.Text;

            if (teContractTheme.Text == "")
                currContract.Theme = null;
            else
                if (currContract.Theme != teContractTheme.Text)
                    currContract.Theme = teContractTheme.Text;

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
            currContract.AuthorID = Properties.Settings.CurrentUserID;

            string number = string.Empty;
            string day = currContract.Date.Value.Day.ToString();
            if (day.Length == 1) day = "0" + day;
            string month = currContract.Date.Value.Month.ToString();
            if (month.Length == 1) month = "0" + month;
            string year = currContract.Date.Value.Year.ToString();
            year = year.Substring(2);
            int today_number = dbContext.Contract.Where(x => x.Date == DateTime.Today).Count() + 1;
            string prefix = dbContext.Departments.Where(x => x.ID == currContract.DepartmentID).Select(y => y.Prefix).ToList()[0].ToString();
            string nomenclature = "8";
            string department_index = "?";
            number = day + month + year + "-" + today_number.ToString() + prefix + nomenclature + "/" + department_index;
            //if (currContract.Number == null)
                currContract.Number = number;

            if (this.contractID == 0)
            {
                dbContext.Contract.Add(currContract);
                Text = "Договор № " + currContract.Number + " от " + String.Format("{0:dd/MM/yyyy}", currContract.Date);
            }
                
            dbContext.SaveChanges();
            teContractNumber.Text = currContract.Number;
            contractID = currContract.ID;
            isLoaded = true;
            uc();
        }

        private void sbSaveChanges_Click(object sender, EventArgs e)
        {
            bool isValid = isValid_deDate();
            if (!isValid)
            {
                deDate_Validating(deDate, new CancelEventArgs());
                lueDepartment_Validating(lueDepartment, new CancelEventArgs());
            }
            else
            {
                isValid = isValid_lueDepartment();
                if (!isValid)
                {
                    lueDepartment_Validating(lueDepartment, new CancelEventArgs());
                }
                else
                {
                    SaveContracChanges();
                    sbSaveChanges.Enabled = false;
                    simpleButton1.Enabled = true;
                }
            }
        }

        #endregion

        #region Отправить на согласование

        private void SendContractToSigning()
        {
            foreach (var user in dbContext.AgreementSignList.Select(x => x.ID).ToList())
            {
                DB.Signing tmpSigning = new DB.Signing();
                tmpSigning.UserID = user;
                tmpSigning.ContractID = currContract.ID;
                //tmpSigning.DeadlineTime = DateTime.Now.AddDays(Properties.Settings.con.DaysToDeadline);
                tmpSigning.DeadlineTime = DateTime.Now.AddDays(4);

                tmpSigning.IsAgreed = false;
                dbContext.Signing.Add(tmpSigning);     
            }
            dbContext.SaveChanges();
        }

        private void FillAgreemenst()
        {
            gcAgreements.DataSource = dbContext.Signing.Where(x => x.ContractID == currContract.ID).Select(x => new { FullName = x.Users.FirstName + " " + x.Users.SecondName, x.IsAgreed, x.Note, x.Date, x.DeadlineTime}).ToList();
            gvAgreements.Columns["FullName"].Caption = "Ф.И.О. согласованта";
            gvAgreements.Columns["IsAgreed"].Caption = "Согласовано";
            gvAgreements.Columns["Note"].Caption = "Комментарий";
            gvAgreements.Columns["Date"].Caption = "Дата согласования";
            gvAgreements.Columns["DeadlineTime"].Caption = "Требуется согласовать до";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveContracChanges();

            currContract.OnAgreement = true;
            SendContractToSigning();
            FillAgreemenst();
        }
        #endregion

        #region Equal Check
        private void control_EditValueChanged(object sender, EventArgs e)
        {
            bool isValid = DoValidate(sender);

            if (isLoaded)
            {
                
                if (contractID != 0)
                    if (isValid &&!DataChanged())
                        sbSaveChanges.Enabled = true;
                    else
                        sbSaveChanges.Enabled = false;
            }
        }

        //Придумать оптимизацию на проверку
        // когда-нибудь
        private bool DataChanged()
        {
            if (currContract.CategoryID != (int?)lueContractCategory.EditValue) return false;
            if (currContract.DepartmentID != (int?)lueDepartment.EditValue) return false;
            if (currContract.ContractualID != (int?)lueContractual.EditValue) return false;
            if (currContract.ContractRenewalID != (int?)lueExtensions.EditValue) return false;
            if (currContract.ContractorID != (int?)lueContractors.EditValue) return false;

            if (teSumm.Text == "")
            {
                if (currContract.Summ != null) return false;
            }
            else if (currContract.Summ != Convert.ToDouble(teSumm.Text)) return false;

            if (teContractNote.Text == "")
            {
                if (currContract.Note != null) return false;
            }
            else if (currContract.Note != teContractNote.Text) return false;

            if (teContractTheme.Text == "")
            {
                if (currContract.Theme != null) return false;
            }
            else if (currContract.Theme != teContractTheme.Text) return false;

            if (deDate.Text == "")
            {
                if (currContract.Date != null) return false;
            }
            else if (currContract.Date != Convert.ToDateTime(deDate.Text)) return false;

            if (deContractDateStart.Text == "")
            {
                if (currContract.StartDate != null) return false;
            }
            else if (currContract.StartDate != Convert.ToDateTime(deContractDateStart.Text)) return false;

            if (deContractDateEnd.Text == "")
            {
                if (currContract.EndDate != null) return false;
            }
            else if (currContract.EndDate != Convert.ToDateTime(deContractDateEnd.Text)) return false;

            return true;
        }

        #endregion

        #region Validation

        private bool DoValidate(object sender)
        {
            bool isValid = true;
            if (sender is TextEdit)
                isValid = (sender as TextEdit).DoValidate();
            else if (sender is DateEdit)
                isValid = (sender as DateEdit).DoValidate();
            else if (sender is LookUpEdit)
                isValid = (sender as LookUpEdit).DoValidate();
            return isValid;
        }

        private void teSumm_Validating(object sender, CancelEventArgs e)
        {
            TextEdit te = sender as TextEdit;
            double output;
            bool isInt = Double.TryParse(te.Text, out output);
            if (te.Text != "" && !isInt)
            {
                te.ErrorText = "Некорректная сумма";
                e.Cancel = true;
            }
        }

        private bool isValid_deDate()
        {
            if (deDate.Text == string.Empty || deDate.Text == null)
            {
                deDate.ErrorText = "Некорректная дата";
                return false;
            }
            else
            {
                DateTime output;
                bool isDateTime = DateTime.TryParse(deDate.Text, out output);
                if (!isDateTime)
                {
                    deDate.ErrorText = "Некорректная дата";
                    return false;
                }
            }
            return true;
        }

        private void deDate_Validating(object sender, CancelEventArgs e)
        {
            if (!isValid_deDate()) e.Cancel = true;
        }

        private bool isValid_lueDepartment()
        {
            if (lueDepartment.EditValue == null)
            {
                lueDepartment.ErrorText = "Обязательное поле";
                return false;
            }
            return true;
        }
        private void lueDepartment_Validating(object sender, CancelEventArgs e)
        {
            if (!isValid_lueDepartment()) e.Cancel = true;
        }

        #endregion

    }
}

//commit