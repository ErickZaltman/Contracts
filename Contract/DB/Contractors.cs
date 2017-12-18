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
            Contract = new HashSet<Contract>();
            ContractAnnex = new HashSet<ContractAnnex>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        public int? ContractorTypeID { get; set; }

        [StringLength(50)]
        public string EGRPOU { get; set; }

        [StringLength(350)]
        public string LegalAddress { get; set; }

        [StringLength(350)]
        public string ActualAddress { get; set; }

        public int? TaxTypeID { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string TaxCode { get; set; }

        [StringLength(50)]
        public string EngCode { get; set; }

        [StringLength(50)]
        public string CheckingAccount { get; set; }

        public bool? IsRemoved { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractAnnex> ContractAnnex { get; set; }

        public virtual ContractorType ContractorType { get; set; }

        public virtual TaxesType TaxesType { get; set; }
    }
}
