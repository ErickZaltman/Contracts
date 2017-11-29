namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HistoryChanges
    {
        public int ID { get; set; }

        public int? DocumentTypeID { get; set; }

        public int? DocumentID { get; set; }

        [StringLength(50)]
        public string PropertyName { get; set; }

        [StringLength(50)]
        public string OldValue { get; set; }

        [StringLength(50)]
        public string NewValue { get; set; }

        public int? AuthorID { get; set; }

        public DateTime? Date { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual DocumentTypes DocumentTypes { get; set; }

        public virtual Users Users { get; set; }
    }
}
