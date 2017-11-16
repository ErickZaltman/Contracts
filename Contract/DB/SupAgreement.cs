namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupAgreement")]
    public partial class SupAgreement
    {
        public int ID { get; set; }

        public int? ContractID { get; set; }

        public int? AuthorID { get; set; }

        [StringLength(256)]
        public string Text { get; set; }

        public DateTime? Date { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual Users Users { get; set; }
    }
}
