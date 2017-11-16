using Contract.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contract
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private DBModel hz;
        public Form1()
        {
            InitializeComponent();
            hz = new DBModel();
            MessageBox.Show(hz.Contract.Select(x => x.Theme ).ToList()[0].ToString());
        }
    }
}



//hui
//hui
//hui
