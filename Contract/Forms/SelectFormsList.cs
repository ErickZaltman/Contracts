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
            Text = "Договора";
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
                Name = x.FullName
            }).ToList();

            gvList.Columns["ID"].Visible = false;

            gvList.Columns["Number"].Caption = "Номер договора";
            gvList.Columns["Category"].Caption = "Категория договора";
            gvList.Columns["Theme"].Caption = "Предмет договора";
            gvList.Columns["Summ"].Caption = "Сумма договора";
            gvList.Columns["Name"].Caption = "Автор";
        }

   

    }
    class SupAgreementsSelectForm : SelectForm
    {
        public SupAgreementsSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.SupAgreements;
            Text = "Доп. соглашения";
            fillGV();
        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.SupAgreement.Join(dbContext.getFullUserName, e => e.AuthorID, x => x.ID, (e, x) => new
            {

                e.ID,
                e.Number,
                Name = x.FullName
            }).ToList();

            gvList.Columns["ID"].Visible = false;

            //gvList.Columns["Number"].Caption = "Номер договора";
            //gvList.Columns["Category"].Caption = "Категория договора";
            //gvList.Columns["Theme"].Caption = "Предмет договора";
            //gvList.Columns["Summ"].Caption = "Сумма договора";
            //gvList.Columns["Name"].Caption = "Автор";
        }

       

    }
    class SigningSelectForm : SelectForm
    {
        public SigningSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Signings;
            Text = "Согласования";
            fillGV();
        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.Signing.Join(dbContext.getFullUserName, e => e.UserID, x => x.ID, (e, x) => new
            {

                e.ID,
                e.Contract.Number,
                Name = x.FullName,
                e.IsAgreed
            }).ToList();

            gvList.Columns["ID"].Visible = false;

            //gvList.Columns["Number"].Caption = "Номер договора";
            //gvList.Columns["Category"].Caption = "Категория договора";
            //gvList.Columns["Theme"].Caption = "Предмет договора";
            //gvList.Columns["Summ"].Caption = "Сумма договора";
            //gvList.Columns["Name"].Caption = "Автор";
        }

       

    }
    class AnnexesSelectForm : SelectForm
    {
        public AnnexesSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Contracts;
            Text = "Приложения";
            fillGV();
        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.ContractAnnex.Join(dbContext.getFullUserName, e => e.AuthorID, x => x.ID, (e, x) => new
            {

                e.ID,
                e.Number,
                Name = x.FullName
            }).ToList();

            gvList.Columns["ID"].Visible = false;

            //gvList.Columns["Number"].Caption = "Номер договора";
            //gvList.Columns["Category"].Caption = "Категория договора";
            //gvList.Columns["Theme"].Caption = "Предмет договора";
            //gvList.Columns["Summ"].Caption = "Сумма договора";
            //gvList.Columns["Name"].Caption = "Автор";
        }

       

    }
    //class DisagreementsSelectForm : SelectForm
    //{
    //    public DisagreementsSelectForm()
    //    {
    //        dbContext = new DB.DBModel();
    //        table = Tables.Contracts;
    //        fillGV();
    //    }

    //    private void fillGV()
    //    {
    //        gridControl1.DataSource = dbContext..Join(dbContext.getFullUserName, e => e.AuthorID, x => x.ID, (e, x) => new
    //        {

    //            e.ID,
    //            e.Number,
    //            Category = e.ContractCategory.Name,
    //            e.Theme,
    //            e.Summ,
    //            Name = x.FullName,
    //        }).ToList();

    //        gvList.Columns["ID"].Visible = false;

    //        gvList.Columns["Number"].Caption = "Номер договора";
    //        gvList.Columns["Category"].Caption = "Категория договора";
    //        gvList.Columns["Theme"].Caption = "Предмет договора";
    //        gvList.Columns["Summ"].Caption = "Сумма договора";
    //        gvList.Columns["Name"].Caption = "Автор";
    //    }

    

    //}
    class DepartmentsSelectForm : SelectForm
    {
        public DepartmentsSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Departments;
            Text = "Департаменты";
            fillGV();
        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.Departments.Select(x => new { x.ID, x.Name, x.Parent }).ToList();

            gvList.Columns["ID"].Visible = false;

            //gvList.Columns["Number"].Caption = "Номер договора";
            //gvList.Columns["Category"].Caption = "Категория договора";
            //gvList.Columns["Theme"].Caption = "Предмет договора";
            //gvList.Columns["Summ"].Caption = "Сумма договора";
            //gvList.Columns["Name"].Caption = "Автор";
        }

     

    }
    class UsersSelectForm : SelectForm
    {
        public UsersSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Users;
            Text = "Сотрудники";
            fillGV();
        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.Users.Join(dbContext.getFullUserName, e => e.ID, x => x.ID, (e, x) => new
            {

                e.ID,
                depName = e.Departments1.Name,
                Name = x.FullName,
            }).ToList();

            gvList.Columns["ID"].Visible = false;

            gvList.Columns["Number"].Caption = "Номер договора";
            gvList.Columns["Category"].Caption = "Категория договора";
            gvList.Columns["Theme"].Caption = "Предмет договора";
            gvList.Columns["Summ"].Caption = "Сумма договора";
            gvList.Columns["Name"].Caption = "Автор";
        }

      

    }
    class ActivityKindsSelectForm : SelectForm
    {
        public ActivityKindsSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.ActivityKinds;
            Text = "Виды деятельности";
            fillGV();
        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.ActivityKind.Select(x => new { x.ID, x.Name }).ToList();

            gvList.Columns["ID"].Visible = false;
        }

       

    }
    class ContractorsSelectForm : SelectForm
    {
        public ContractorsSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Contractors;
            Text = "Контрагенты";
            fillGV();
        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.Contractors.Select(x => new { x.ID, x.Name, x.ActualAddress }).ToList();

            gvList.Columns["ID"].Visible = false;
        }

       

    }
    class CategorySelectForm : SelectForm
    {
        public CategorySelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Category;
            Text = "Категории договоров";
            fillGV();
        }

        public CategorySelectForm(bool isSelection, getIDFromForm sender)
        {
            dbContext = new DB.DBModel();
            table = Tables.Category;
            Text = "Категории договоров";

            this.d = sender;
            this.isSelection = isSelection;
            fillGV();
        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.ContractCategory.Select(x => new { x.ID, x.Name }).ToList();

            gvList.Columns["ID"].Visible = false;
        }



    }

}
