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
    public partial class ContractAnnexForm : DevExpress.XtraEditors.XtraForm
    {
        private DB.DBModel dbContext;
        private DB.ContractAnnex currAnnex;

        public ContractAnnexForm()
        {
            InitializeComponent();
            dbContext = new DB.DBModel();
            fillControls();
        }

        public ContractAnnexForm(int annexID)
        {
            InitializeComponent();
            dbContext = new DB.DBModel();
            currAnnex = dbContext.ContractAnnex.Where(x => x.ID == annexID).ToList()[0];

            fillControls();
            fillExisting();

        }


        private void fillControls()
        {
            lueAnnexType.Properties.DisplayMember = "Text";
            lueAnnexType.Properties.ValueMember = "Value";
            lueAnnexType.Properties.DataSource = dbContext.AnnexTypes.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

            lueContract.Properties.DisplayMember = "Text";
            lueContract.Properties.ValueMember = "Value";
            lueContract.Properties.DataSource = dbContext.Contract.Select(x => new { Value = x.ID, Text = x.Number }).ToList();

            lueContractor.Properties.DisplayMember = "Text";
            lueContractor.Properties.ValueMember = "Value";
            lueContractor.Properties.DataSource = dbContext.Contractors.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

            lueSendType.Properties.DisplayMember = "Text";
            lueSendType.Properties.ValueMember = "Value";
            lueSendType.Properties.DataSource = dbContext.SendTypes.Select(x => new { Value = x.ID, Text = x.Name }).ToList();

        }
        private void fillExisting()
        {
            lueAnnexType.EditValue = currAnnex.AnnexTypeID;
            lueContract.EditValue = currAnnex.ContractID;
            lueContractor.EditValue = currAnnex.ContractorID;
            lueSendType.EditValue = currAnnex.SendTypeID;

            teAuthor.Text = currAnnex.Users1.Surname;
            teNumber.Text = currAnnex.Number;

            deDate.DateTime = (DateTime)currAnnex.ActionDate;
            deSendDate.DateTime = (DateTime)currAnnex.SendDate;
            deSigningDateUs.DateTime = (DateTime)currAnnex.SigningDateUS;
            deSigningDateContractor.DateTime = (DateTime)currAnnex.SigningDateContractor;

        }
    }
}