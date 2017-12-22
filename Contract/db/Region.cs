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
        public int ID { get; set; }

        public int? ParentID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Code { get; set; }

        public int? RegionGroupID { get; set; }
    }
}
