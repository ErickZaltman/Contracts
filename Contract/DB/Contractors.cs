namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contractors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contractors()
        {
            ContractAnnex = new HashSet<ContractAnnex>();
            Contracts = new HashSet<Contracts>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(350)]
        public string FullName { get; set; }

        public int? TaxTypeID { get; set; }

        public int? ContractorTypeID { get; set; }

        [StringLength(50)]
        public string EDRPOU { get; set; }

        [StringLength(350)]
        public string LegalAddress { get; set; }

        [StringLength(350)]
        public string ActualAddress { get; set; }

        [StringLength(150)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string INN { get; set; }

        [StringLength(50)]
        public string TaxCode { get; set; }

        [StringLength(50)]
        public string EngCode { get; set; }

        [StringLength(50)]
        public string CheckingAccount { get; set; }

        [StringLength(50)]
        public string Person { get; set; }

        [StringLength(50)]
        public string ProofDocument { get; set; }

        public int? RegionID { get; set; }

        [StringLength(50)]
        public string DRFOCode { get; set; }

        public int? GroupID { get; set; }

        public int? IndustryID { get; set; }

        public bool? IsLegalEntity { get; set; }

        public bool? IsCustomer { get; set; }

        public bool? IsRemoved { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractAnnex> ContractAnnex { get; set; }

        public virtual ContractorGroups ContractorGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contracts> Contracts { get; set; }

        public virtual ContractorType ContractorType { get; set; }

        public virtual Industry Industry { get; set; }

        public virtual Region Region { get; set; }

        public virtual TaxesType TaxesType { get; set; }
    }
}
