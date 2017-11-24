namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Signing")]
    public partial class Signing
    {
        public int ID { get; set; }

        public int? ContractID { get; set; }

        public int? UserID { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        public bool? IsAgreed { get; set; }

        public DateTime? DeadlineTime { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual Users Users { get; set; }
    }
}
