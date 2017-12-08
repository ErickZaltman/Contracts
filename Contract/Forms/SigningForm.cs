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
    public partial class SigningForm : DevExpress.XtraEditors.XtraForm
    {
        private UpdateContracts d;
        private DB.DBModel dbContext;
        private int contractID;
        private int signID;
        private DB.Contract currContract;
        public SigningForm(int signID)
        {
            InitializeComponent();

            dbContext = new DB.DBModel();
            this.signID = signID;
            //this.contractID = contractID;

            currContract = dbContext.Contract.Where(x => x.ID == contractID).ToList()[0];
            fillDocInfo();
            fillGVSign();
            if((bool)dbContext.Signing.Where(x => x.ID == signID).ToList()[0].IsAgreed)
            {
                sbAgree.Visible = false;
            }
        }

        private void fillDocInfo()
        {
            teActivity.Text = currContract.ActivityKind.Name;
            teCategory.Text = currContract.ContractCategory.Name;
            teContractual.Text = currContract.Users1.Surname + " " + currContract.Users1.FirstName[0] + "." + currContract.Users1.SecondName[0] + ".";
            teContractor.Text = currContract.Contractors.Name;
            teDate.Text = currContract.Date.ToString();
            teDepartment.Text = currContract.Departments.Name;
            teNumber.Text = currContract.Number;
            teSumm.Text = currContract.Summ.ToString();
            teTheme.Text = currContract.Theme;
        }

        private void fillGVSign()
        {
            gridControl1.DataSource = dbContext.Signing.Where(x => x.ContractID == contractID).Select(x => new
            {
                x.ID,
                Name = x.Users.Surname + " " + x.Users.FirstName.Substring(0, 1) + "." + x.Users.SecondName.Substring(0, 1) + ".",
                x.Note,
                x.IsAgreed,
                x.DeadlineTime
            }).ToList();
            gvSigns.Columns["ID"].Visible = false;
        }
        private void SigningForm_Load(object sender, EventArgs e)
        {

        }

        private void sbAgree_Click(object sender, EventArgs e)
        {
            DB.Signing tmpSign = dbContext.Signing.Where(x => x.ID == signID).ToList()[0];
            tmpSign.IsAgreed = true;
            tmpSign.Date = DateTime.Now;
            dbContext.SaveChanges();
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}