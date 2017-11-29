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

        public int? ContractorID { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        public int? AuthorID { get; set; }

        public double? Summ { get; set; }

        [StringLength(250)]
        public string Theme { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? ConclusionDate { get; set; }

        public int? ContractualID { get; set; }

        public int? ActivityKindID { get; set; }

        public int? CategoryID { get; set; }

        public int? ContractRenewalID { get; set; }

        public int? ContractRenewalTimeID { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        public DateTime? Date { get; set; }

        public int? DepartmentID { get; set; }

        public bool? OnAgreement { get; set; }

        public virtual ActivityKind ActivityKind { get; set; }

        public virtual ContractCategory ContractCategory { get; set; }

        public virtual ContractRenewal ContractRenewal { get; set; }

        public virtual ContractRenewalPeriod ContractRenewalPeriod { get; set; }

        public virtual Contractors Contractors { get; set; }

        public virtual Departments Departments { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Files> Files { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryChanges> HistoryChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Signing> Signing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupAgreement> SupAgreement { get; set; }
    }
}
