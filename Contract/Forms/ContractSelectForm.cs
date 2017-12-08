using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Forms
{
    class ContractSelectForm : SelectForm
    {
        public ContractSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Contracts;
            fillGV();
        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.Contract.Join(dbContext.getFullUserName, e => e.AuthorID, x => x.ID, (e, x) => new
            {
               
                e.ID,
                e.Number,
                Category = e.ContractCategory.Name,
                e.Theme,
                e.Summ,
                Name = x.FullName,
            }).ToList();

            gvList.Columns["ID"].Visible = false;

            gvList.Columns["Number"].Caption = "Номер договора";
            gvList.Columns["Category"].Caption = "Категория договора";
            gvList.Columns["Theme"].Caption = "Предмет договора";
            gvList.Columns["Summ"].Caption = "Сумма договора";
            gvList.Columns["Name"].Caption = "Автор";
        }

        protected  new void  openDocForm(int id, Tables type)
        {
            MessageBox.Show("123");
        }

    }
}
