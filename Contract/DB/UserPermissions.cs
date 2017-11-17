namespace Contract.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserPermissions
    {
        public int? UserID { get; set; }

        public int? PermissionID { get; set; }

        public int ID { get; set; }

        public virtual Permissions Permissions { get; set; }

        public virtual Users Users { get; set; }
    }
}
