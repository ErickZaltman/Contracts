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
    public partial class SupAgreementForm : DevExpress.XtraEditors.XtraForm
    {
        DB.DBModel dbContext;
        private DB.SupAgreement currentAgreement;
        public SupAgreementForm(int supAgreementID)
        {
            InitializeComponent();
            dbContext = new DB.DBModel();

            currentAgreement = dbContext.SupAgreement.Where(x => x.ID == supAgreementID).ToList()[0];
            fillControls();
            fillExisting();

        }

        public void fillControls()
        {
            lueContract.Properties.DisplayMember = "Text";
            lueContract.Properties.ValueMember = "Value";
            lueContract.Properties.DataSource = dbContext.Contract.Select(x => new { Value = x.ID, Text = x.Number  }).ToList();
        }
        public void fillExisting()
        {
            lueContract.EditValue = currentAgreement.ContractID;
            teAuthor.Text = currentAgreement.Users.Surname;
            if (currentAgreement.Date != null)
                deDate.DateTime = (DateTime)currentAgreement.Date;
            teNumber.Text = currentAgreement.Number;

        }
    }
}