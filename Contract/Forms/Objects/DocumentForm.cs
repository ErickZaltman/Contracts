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
    public partial class DocumentForm : DevExpress.XtraEditors.XtraForm
    {

        protected int currentID;
        public DocumentForm()
        {
            InitializeComponent();
        }

        private void DocumentForm_Load(object sender, EventArgs e)
        {

        }
    }
}