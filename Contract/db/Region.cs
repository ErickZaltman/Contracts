namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Region")]
    public partial class Region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Region()
        {
            Contractors = new HashSet<Contractors>();
        }

        public int ID { get; set; }

        public int? ParentID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Code { get; set; }

        public int? RegionGroupID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contractors> Contractors { get; set; }

        public virtual RegionGroup RegionGroup { get; set; }
    }
}
