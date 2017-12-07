namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getFullUserName")]
    public partial class getFullUserName
    {
        public int ID { get; set; }

        [StringLength(55)]
        public string FullName { get; set; }
    }
}
