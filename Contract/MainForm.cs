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
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private string currentUserLogin;
        private DBModel hz;
        public MainForm()
        {
            InitializeComponent();
            hz = new DBModel();
           
        }
        public MainForm(string userLogin)
        {
            InitializeComponent();
            currentUserLogin = userLogin;
            hz = new DBModel();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}




