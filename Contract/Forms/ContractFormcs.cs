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

            deDate.DateTime = (DateTime)currContract.Date;
            deContractDateEnd.DateTime = (DateTime)currContract.EndDate;
            deContractDateStart.DateTime = (DateTime)currContract.StartDate;

        }
        private void fillControls()
        {
            MessageBox.Show(contractID.ToString());


        }


        private void tbContractDate_Load(object sender, EventArgs e)
        {

        }
    }
}