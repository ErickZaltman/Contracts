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
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        public int? GroupID { get; set; }

        [StringLength(50)]
        public string EGRPOU { get; set; }

        [StringLength(350)]
        public string LegalAdress { get; set; }

        [StringLength(350)]
        public string ActualAdress { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }

        public virtual ContractorType ContractorType { get; set; }
    }
}
