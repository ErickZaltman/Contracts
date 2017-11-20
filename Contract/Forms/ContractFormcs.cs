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

            beContractCategory.Text = currContract.ContractCategory.Name;
            beContractual.Text = currContract.Users1.Surname + " " + currContract.Users1.FirstName[0] + ". " + currContract.Users1.SecondName[0] + ".";
            beDepartment.Text = currContract.Departments.Name;

            deDate.DateTime = (DateTime)currContract.Date;
            deContractDateEnd.DateTime = (DateTime)currContract.EndDate;
            deContractDateStart.DateTime = (DateTime)currContract.StartDate;

            lueExtensions.Properties.DisplayMember = "Text";
            lueExtensions.Properties.ValueMember = "Values";
            lueExtensions.Properties.DataSource = dbContext.ContractExtension.Select(x => new { Value = x.ID, Text = x.Name }).ToArray();


            hzhz.DisplayMember = "Text";
            hzhz.ValueMember = "Values";            
            hzhz.DataSource = dbContext.ContractExtension.Select(x => new { Value = x.ID, Text = x.Name }).ToArray();
        }
        private void fillControls()
        {


        }


        private void tbContractDate_Load(object sender, EventArgs e)
        {

        }

        

        private void beContractCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SelectInfoForm tmpForm = new SelectInfoForm("Category", dbContext);
            
            tmpForm.ShowDialog();

        }

        private void beContractual_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SelectInfoForm tmpForm = new SelectInfoForm("Users", dbContext);

            tmpForm.ShowDialog();
        }

        private void beDepartment_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SelectInfoForm tmpForm = new SelectInfoForm("Departments", dbContext);

            tmpForm.ShowDialog();
        }
    }
}