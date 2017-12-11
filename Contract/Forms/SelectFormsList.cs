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
        private static object inst;
        public static ContractSelectForm getInst()
        {
            if (inst == null)
                inst = new ContractSelectForm();
            return inst as ContractSelectForm;
        }


        public ContractSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Contracts;
            Text = "Договора";
            fillGV();
            this.FormClosed += ContractSelectForm_FormClosed;
        }

        private void ContractSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inst = null;
        }

        private void ContractSelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("hui");
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

        private static object inst;

        public static SupAgreementsSelectForm getInst()
        {
            if (inst == null)
                inst = new SupAgreementsSelectForm();
            return inst as SupAgreementsSelectForm;
        }
        public SupAgreementsSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.SupAgreements;
            Text = "Доп. соглашения";
            fillGV();
            FormClosed += SupAgreementsSelectForm_FormClosed;
        }

        private void SupAgreementsSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inst = null;
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
        private static object inst;

        public static SigningSelectForm getInst()
        {
            if (inst == null)
                inst = new SigningSelectForm();
            return inst as SigningSelectForm;
        }
        public SigningSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Signings;
            Text = "Согласования";
            fillGV();
            FormClosed += SigningSelectForm_FormClosed;
        }

        private void SigningSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inst = null;

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
        private static object inst;

        public static AnnexesSelectForm getInst()
        {
            if (inst == null)
                inst = new AnnexesSelectForm();
            return inst as AnnexesSelectForm;
        }
        public AnnexesSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Contracts;
            Text = "Приложения";
            fillGV();
            FormClosed += AnnexesSelectForm_FormClosed;
        }

        private void AnnexesSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inst = null;

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
        private static object inst;

        public static DepartmentsSelectForm getInst()
        {
            if (inst == null)
                inst = new DepartmentsSelectForm();
            return inst as DepartmentsSelectForm;
        }
        public DepartmentsSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Departments;
            Text = "Департаменты";
            fillGV();
            FormClosed += DepartmentsSelectForm_FormClosed;
        }

        private void DepartmentsSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inst = null;

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
        private static object inst;

        public static UsersSelectForm getInst()
        {
            if (inst == null)
                inst = new UsersSelectForm();
            return inst as UsersSelectForm;
        }
        public UsersSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Users;
            Text = "Сотрудники";
            fillGV();
            FormClosed += UsersSelectForm_FormClosed;
        }

        private void UsersSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inst = null;

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
        private static object inst;

        public static ActivityKindsSelectForm getInst()
        {
            if (inst == null)
                inst = new ActivityKindsSelectForm();
            return inst as ActivityKindsSelectForm;
        }
        public ActivityKindsSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.ActivityKinds;
            Text = "Виды деятельности";
            fillGV();
            FormClosed += ActivityKindsSelectForm_FormClosed;
        }

        private void ActivityKindsSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inst = null;

        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.ActivityKind.Select(x => new { x.ID, x.Name }).ToList();

            gvList.Columns["ID"].Visible = false;
        }

       

    }
    class ContractorsSelectForm : SelectForm
    {
        private static object inst;


        public static ContractorsSelectForm getInst()
        {
            if (inst == null)
                inst = new ContractorsSelectForm();
            return inst as ContractorsSelectForm;
        }
        public ContractorsSelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Contractors;
            Text = "Контрагенты";
            fillGV();
            FormClosed += ContractorsSelectForm_FormClosed;
        }

        private void ContractorsSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inst = null;

        }

        private void fillGV()
        {
            gridControl1.DataSource = dbContext.Contractors.Select(x => new { x.ID, x.Name, x.ActualAddress }).ToList();

            gvList.Columns["ID"].Visible = false;
        }

       

    }
    class CategorySelectForm : SelectForm
    {
        private static object inst;

        public static CategorySelectForm getInst()
        {
            if (inst == null)
                inst = new CategorySelectForm();
            return inst as CategorySelectForm;
        }
        public CategorySelectForm()
        {
            dbContext = new DB.DBModel();
            table = Tables.Category;
            Text = "Категории договоров";
            fillGV();
            FormClosed += CategorySelectForm_FormClosed;
        }

        private void CategorySelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inst = null;

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
