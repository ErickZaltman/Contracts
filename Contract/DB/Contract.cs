namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            Files = new HashSet<Files>();
            HistoryChanges = new HashSet<HistoryChanges>();
            Signing = new HashSet<Signing>();
            SupAgreement = new HashSet<SupAgreement>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        public int? AuthorID { get; set; }

        public double? Summ { get; set; }

        [StringLength(50)]
        public string Theme { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? ContractualID { get; set; }

        public int? ActivityKindID { get; set; }

        public int? CategoryID { get; set; }

        public int? ContractExtension { get; set; }

        public int? ContractExtensionTime { get; set; }

        public virtual ActivityKind ActivityKind { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Files> Files { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryChanges> HistoryChanges { get; set; }

        public virtual ContractExtension ContractExtension1 { get; set; }

        public virtual ContractExtensionPeriod ContractExtensionPeriod { get; set; }

        public virtual OrderCategory OrderCategory { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Signing> Signing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupAgreement> SupAgreement { get; set; }
    }
}
