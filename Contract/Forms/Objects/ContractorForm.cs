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
    public partial class ContractorForm : DevExpress.XtraEditors.XtraForm
    {
        private DB.Contractors currentContractor;
        private DB.DBModel dbContext;
        private int currentID;

        public ContractorForm(int id)
        {
            InitializeComponent();
            dbContext = new DB.DBModel();

            this.currentID = id;

            if (currentID != 0)
            {
                currentContractor = dbContext.Contractors.First(x => x.ID == id);
                FillExistingContractor();
                Text = currentContractor.Name;
            }
            else
            {
                currentContractor = new DB.Contractors();
                Text = "Новый контрагент";
            }
            fillContorls();
        }

        private void fillContorls()
        {
            lueGroup.Properties.DisplayMember = "Text";
            lueGroup.Properties.ValueMember = "Value";
            lueGroup.Properties.DataSource = dbContext.ContractorType.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

            lueTaxType.Properties.DisplayMember = "Text";
            lueTaxType.Properties.ValueMember = "Value";
            lueTaxType.Properties.DataSource = dbContext.TaxesType.Select(x => new { Value = x.ID, Text = x.Name }).ToList();
        }

        private void FillExistingContractor()
        {
            teName.Text = currentContractor.Name;
            meFullName.Text = currentContractor.FullName;
            teEGRPOU.Text = currentContractor.EGRPOU;
            teLegalAddress.Text = currentContractor.LegalAddress;
            teActualAddress.Text = currentContractor.ActualAddress;
            teTaxCode.Text = currentContractor.TaxCode;
            teEngCode.Text = currentContractor.EngCode;
            teCheckingAccount.Text = currentContractor.CheckingAccount;
            tePhoneNumber.Text = currentContractor.PhoneNumber;
            teEmail.Text = currentContractor.Email;

            lueGroup.EditValue = currentContractor.ContractorTypeID;
            lueTaxType.EditValue = currentContractor.TaxTypeID;
        }

        #region Save Changes
        public void SaveContractorChanges()
        {
            if (teName.Text == "")
                currentContractor.Name = null;
            else
                if (currentContractor.Name != teName.Text)
                currentContractor.Name = teName.Text;
            //
            if (meFullName.Text == "")
                currentContractor.FullName = null;
            else
                if (currentContractor.FullName != meFullName.Text)
                currentContractor.FullName = meFullName.Text;
            //
            if (teEGRPOU.Text == "")
                currentContractor.EGRPOU = null;
            else
                if (currentContractor.EGRPOU != teEGRPOU.Text)
                currentContractor.EGRPOU = teEGRPOU.Text;
            //
            if (teEGRPOU.Text == "")
                currentContractor.EGRPOU = null;
            else
                if (currentContractor.EGRPOU != teEGRPOU.Text)
                currentContractor.EGRPOU = teEGRPOU.Text;
            //
            if (teLegalAddress.Text == "")
                currentContractor.LegalAddress = null;
            else
               if (currentContractor.LegalAddress != teLegalAddress.Text)
                currentContractor.LegalAddress = teLegalAddress.Text;
            //
            if (teActualAddress.Text == "")
                currentContractor.ActualAddress = null;
            else
               if (currentContractor.ActualAddress != teActualAddress.Text)
                currentContractor.ActualAddress = teActualAddress.Text;
            //
            if (teTaxCode.Text == "")
                currentContractor.TaxCode = null;
            else
               if (currentContractor.TaxCode != teTaxCode.Text)
                currentContractor.TaxCode = teTaxCode.Text;
            //
            if (teEngCode.Text == "")
                currentContractor.EngCode = null;
            else
               if (currentContractor.EngCode != teEngCode.Text)
                currentContractor.EngCode = teEngCode.Text;
            //
            if (teCheckingAccount.Text == "")
                currentContractor.CheckingAccount = null;
            else
              if (currentContractor.CheckingAccount != teCheckingAccount.Text)
                currentContractor.CheckingAccount = teCheckingAccount.Text;
            //
            if (tePhoneNumber.Text == "")
                currentContractor.PhoneNumber = null;
            else
              if (currentContractor.PhoneNumber != tePhoneNumber.Text)
                currentContractor.PhoneNumber = tePhoneNumber.Text;
            //
            if (teEmail.Text == "")
                currentContractor.Email = null;
            else
             if (currentContractor.Email != teEmail.Text)
                currentContractor.Email = teEmail.Text;
            //
            if (lueGroup.Text != "" && lueGroup.EditValue != null && currentContractor.ContractorTypeID != (int)lueGroup.EditValue)
                currentContractor.ContractorTypeID = (int)lueGroup.EditValue;
            //
            if (lueTaxType.Text != "" && lueTaxType.EditValue != null && currentContractor.TaxTypeID != (int)lueTaxType.EditValue)
                currentContractor.TaxTypeID = (int)lueTaxType.EditValue;

            if (currentID == 0)
                dbContext.Contractors.Add(currentContractor);

            dbContext.SaveChanges();
        }

        public string GetName()
        {
            return currentContractor.Name;
        }
        #endregion

        #region Validation
        public bool IsValid()
        {
            return true;
        }
        #endregion
    }
}