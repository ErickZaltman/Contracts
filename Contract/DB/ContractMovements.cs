namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContractMovements
    {
        public int ID { get; set; }

        public int? ContractID { get; set; }

        public DateTime? Date { get; set; }

        public int? MovementTypeID { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        public int? AuthorID { get; set; }

        public virtual Contracts Contracts { get; set; }

        public virtual MovementTypes MovementTypes { get; set; }

        public virtual Users Users { get; set; }
    }
}
