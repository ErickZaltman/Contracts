using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace Contract
{
    static class Program
    {
        public static Dictionary<Tables, Type> TypesList;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            initDict();
            Application.Run(new ParentForm(3));
        }
        public static void initDict()
        {
            TypesList = new Dictionary<Tables, Type>();

            TypesList.Add(Tables.Contracts, typeof(Forms.ContractForm));
            TypesList.Add(Tables.SupAgreements, typeof(Forms.SupAgreementForm));
            TypesList.Add(Tables.Signings, typeof(Forms.SigningForm));
            TypesList.Add(Tables.Annexes, typeof(Forms.ContractAnnexForm));
            TypesList.Add(Tables.Departments, typeof(Forms.tmp));
            TypesList.Add(Tables.Users, typeof(Forms.tmp));
            TypesList.Add(Tables.ActivityKinds, typeof(Forms.tmp));
            TypesList.Add(Tables.Contractors, typeof(Forms.ContractorForm));

        }
    }
}
