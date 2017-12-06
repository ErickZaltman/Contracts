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

namespace Contract
{
    public partial class ParentForm : DevExpress.XtraEditors.XtraForm
    {

        ////TODO 
        //Конструктор с айдишником пользователя
        //Убрать конструктор с айдишником из MainForm
        //Придумать кнопки
        //Прицепить имя пользователя на статусБар


        public ParentForm()
        {
            InitializeComponent();

            

            var tmpForm = new MainForm(3);
            tmpForm.MdiParent = this;
            tmpForm.Show();
        }
    }
}