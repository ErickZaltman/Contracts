namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractAnnex")]
    public partial class ContractAnnex
    {
        public int ID { get; set; }

        public int? ContractID { get; set; }

        public int? AnnexTypeID { get; set; }

        public int? ContractorID { get; set; }

        public int? AuthorID { get; set; }

        public DateTime? ActionDate { get; set; }

        public int? SendTypeID { get; set; }
        public string Number { get; set; }

        public DateTime? SendDate { get; set; }

        public DateTime? SigningDateUS { get; set; }

        public DateTime? SigningDateContractor { get; set; }

        public virtual AnnexTypes AnnexTypes { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual Contractors Contractors { get; set; }

        public virtual SendTypes SendTypes { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
