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
        public ContractorForm()
        {
            InitializeComponent();
            dbContext = new DB.DBModel();
            fillContorls();
        }

        public ContractorForm(int id)
        {
            InitializeComponent();
            dbContext = new DB.DBModel();
            currentContractor = dbContext.Contractors.Where(x => x.ID == id).ToList()[0];

            fillContorls();
            FillExistingContractor();
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
    }
}