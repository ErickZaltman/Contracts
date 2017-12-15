namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testtable")]
    public partial class testtable
    {
        public int id { get; set; }

        [StringLength(50)]
        public string txt { get; set; }
    }
}
