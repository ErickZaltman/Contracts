namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegionGroup")]
    public partial class RegionGroup
    {
        public int ID { get; set; }

        [StringLength(75)]
        public string Name { get; set; }
    }
}
