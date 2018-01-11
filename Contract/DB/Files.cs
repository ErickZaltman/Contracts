namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Files
    {
        public int ID { get; set; }

        public int? ContractID { get; set; }

        [StringLength(250)]
        public string DirectoryName { get; set; }

        [StringLength(50)]
        public string FileName { get; set; }

        public virtual Contracts Contracts { get; set; }
    }
}
