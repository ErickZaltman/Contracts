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
    public partial class SelectTreeForm : DevExpress.XtraEditors.XtraForm
    {
        protected string type;
        protected Tables table;
        protected DB.DBModel dbContext;
        protected bool isSelection = false;

        protected getIDFromForm d;

        public Tables Table
        {
            get
            {
                return table;
            }

            set
            {
                table = value;
            }
        }

        public SelectTreeForm()
        {
            InitializeComponent();
        }
        public SelectTreeForm(Tables table)
        {
            InitializeComponent();
            this.Table = table;
            this.dbContext = new DB.DBModel();
        }
        public SelectTreeForm(Tables table, bool isSelection, getIDFromForm sender)
        {
            InitializeComponent();
            d = sender;
            this.Table = table;
            this.isSelection = isSelection;
            this.dbContext = new DB.DBModel();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks > 1)
            {
                if (isSelection)
                {
                    d((int)gvList.GetRowCellValue(e.RowHandle, "ID"), Table);
                    Close();
                    return;
                }
                openDocForm((int)gvList.GetRowCellValue(e.RowHandle, "ID"));
            }
        }
        protected void openDocForm(int id)
        {
            var tmpForm = (MdiParent as ParentForm).DocumentManager.addPage(new KeyValuePair<string, Form>(Program.TypesList[table].ToString() + id.ToString(), 
                (Form)Activator.CreateInstance(Program.TypesList[table], id)));
            tmpForm.MdiParent = this.MdiParent;

            tmpForm.Show();

            (MdiParent as ParentForm).xtraTabbedMdiManager1.SelectedPage = (MdiParent as ParentForm).xtraTabbedMdiManager1.Pages[tmpForm];   //Нихуя не соответствует принципам ООП

        }
        private void closeForm()
        {
            if (MessageBox.Show("", "z", MessageBoxButtons.YesNoCancel) == DialogResult.No)
                this.Close();
        }
        
        private void SelectForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //    Close();
        }
    }
    //t
}