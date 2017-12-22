namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContractorGroups
    {
        public int ID { get; set; }

        public int? ParentID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}
