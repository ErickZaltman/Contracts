namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Test2test
    {
        public int id { get; set; }

        [StringLength(50)]
        public string txt { get; set; }

        public int? hz { get; set; }
    }
}
