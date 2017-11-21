using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public class TableName
    {
        private TableName(string value) { Value = value; }

        public string Value { get; set; }

        public static TableName InnerMail { get { return new TableName("InnerMail"); } }
        public static TableName Departments { get { return new TableName("Departments"); } }
        public static TableName Contractors { get { return new TableName("Contractors"); } }
        public static TableName IncomingMail { get { return new TableName("IncomingMail"); } }
        public static TableName OutgoingMail { get { return new TableName("OutgoingMail"); } }
        public static TableName ServiceMail { get { return new TableName("ServiceMail"); } }
        public static TableName TreatmentMail { get { return new TableName("TreatmentMail"); } }
        public static TableName UserInfo { get { return new TableName("UserInfo"); } }
        public static TableName User { get { return new TableName("User"); } }
    }
}
