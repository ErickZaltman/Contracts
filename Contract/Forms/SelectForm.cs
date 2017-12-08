﻿using System;
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
    public partial class SelectForm : DevExpress.XtraEditors.XtraForm
    {
        protected string type;
        protected Tables table;
        protected DB.DBModel dbContext;
        protected bool isSelection = false;

        private getIDFromForm d;
        public SelectForm()
        {
            InitializeComponent();
        }
        public SelectForm(Tables table)
        {
            InitializeComponent();
            this.table = table;
            this.dbContext = new DB.DBModel();
            FillGV();
        }
        public SelectForm(Tables table, bool isSelection, getIDFromForm sender)
        {
            InitializeComponent();
            d = sender;
            this.table = table;
            this.isSelection = isSelection;
            this.dbContext = new DB.DBModel();
            FillGV();
        }

        protected void FillGV()
        {
        }




        private void SelectInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks > 1)
            {
                if (isSelection)
                {
                    d((int)gvList.GetRowCellValue(e.RowHandle, "ID"), table);
                    Close();
                    return;
                }
                openDocForm((int)gvList.GetRowCellValue(e.RowHandle, "ID"), table);

            }
        }
        protected void openDocForm(int id, Tables type)
        {

            var tmpForm = Activator.CreateInstance(Program.TypesList[type]);
            (tmpForm as Form).Show();
        }
        

    }
}