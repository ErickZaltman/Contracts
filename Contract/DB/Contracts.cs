namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contracts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contracts()
        {
            ContractAnnex = new HashSet<ContractAnnex>();
            ContractMovements = new HashSet<ContractMovements>();
            Files = new HashSet<Files>();
            HistoryChanges = new HashSet<HistoryChanges>();
            Signing = new HashSet<Signing>();
            SupAgreement = new HashSet<SupAgreement>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ContractorID { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        public int? AuthorID { get; set; }

        public double? Summ { get; set; }

        [StringLength(1250)]
        public string Theme { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? ConclusionDate { get; set; }

        public int? ContractualID { get; set; }

        public int? ActivityKindID { get; set; }

        public int? CategoryID { get; set; }

        public int? ContractRenewalID { get; set; }

        public int? ContractRenewalTimeID { get; set; }

        [StringLength(150)]
        public string Note { get; set; }

        public DateTime? Date { get; set; }

        public int? DepartmentID { get; set; }

        public bool? OnAgreement { get; set; }

        public bool? IsRemoved { get; set; }

        public virtual ActivityKind ActivityKind { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractAnnex> ContractAnnex { get; set; }

        public virtual ContractCategory ContractCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractMovements> ContractMovements { get; set; }

        public virtual Contractors Contractors { get; set; }

        public virtual ContractRenewal ContractRenewal { get; set; }

        public virtual ContractRenewalPeriod ContractRenewalPeriod { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        public virtual Departments Departments { get; set; }

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
