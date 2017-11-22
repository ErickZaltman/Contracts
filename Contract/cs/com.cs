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

        public static TableName Category { get { return new TableName("Category"); } }
        public static TableName Users { get { return new TableName("Users"); } }
        public static TableName Contractors { get { return new TableName("Contractors"); } }
        public static TableName Departments { get { return new TableName("Departments"); } }
        public static TableName Activities { get { return new TableName("Activities"); } }

        //hz
    }
}
