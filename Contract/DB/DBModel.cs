namespace Contract.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<ActivityKind> ActivityKind { get; set; }
        public virtual DbSet<AgreementSignList> AgreementSignList { get; set; }
        public virtual DbSet<AnnexTypes> AnnexTypes { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<ContractAnnex> ContractAnnex { get; set; }
        public virtual DbSet<ContractCategory> ContractCategory { get; set; }
        public virtual DbSet<Contractors> Contractors { get; set; }
        public virtual DbSet<ContractorType> ContractorType { get; set; }
        public virtual DbSet<ContractRenewal> ContractRenewal { get; set; }
        public virtual DbSet<ContractRenewalPeriod> ContractRenewalPeriod { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DocumentTypes> DocumentTypes { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<HistoryChanges> HistoryChanges { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<SendTypes> SendTypes { get; set; }
        public virtual DbSet<Signing> Signing { get; set; }
        public virtual DbSet<SupAgreement> SupAgreement { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaxesType> TaxesType { get; set; }
        public virtual DbSet<UserPermissions> UserPermissions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnnexTypes>()
                .HasMany(e => e.ContractAnnex)
                .WithOptional(e => e.AnnexTypes)
                .HasForeignKey(e => e.AnnexTypeID);

            modelBuilder.Entity<Contract>()
                .HasMany(e => e.HistoryChanges)
                .WithOptional(e => e.Contract)
                .HasForeignKey(e => e.DocumentID);

            modelBuilder.Entity<ContractCategory>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.ContractCategory)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Contractors>()
                .Property(e => e.TaxCode)
                .IsFixedLength();

            modelBuilder.Entity<Contractors>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.Contractors)
                .HasForeignKey(e => e.ContractorID);

            modelBuilder.Entity<Contractors>()
                .HasMany(e => e.ContractAnnex)
                .WithOptional(e => e.Contractors)
                .HasForeignKey(e => e.ContractorID);

            modelBuilder.Entity<ContractRenewalPeriod>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.ContractRenewalPeriod)
                .HasForeignKey(e => e.ContractRenewalTimeID);

            modelBuilder.Entity<Departments>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.Departments)
                .HasForeignKey(e => e.DepartmentID);

            modelBuilder.Entity<Departments>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.Departments1)
                .HasForeignKey(e => e.DepartmentID);

            modelBuilder.Entity<DocumentTypes>()
                .HasMany(e => e.HistoryChanges)
                .WithOptional(e => e.DocumentTypes)
                .HasForeignKey(e => e.DocumentTypeID);

            modelBuilder.Entity<Permissions>()
                .HasMany(e => e.UserPermissions)
                .WithOptional(e => e.Permissions)
                .HasForeignKey(e => e.PermissionID);

            modelBuilder.Entity<SendTypes>()
                .HasMany(e => e.ContractAnnex)
                .WithOptional(e => e.SendTypes)
                .HasForeignKey(e => e.SendTypeID);

            modelBuilder.Entity<TaxesType>()
                .HasMany(e => e.Contractors)
                .WithOptional(e => e.TaxesType)
                .HasForeignKey(e => e.TaxTypeID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.AgreementSignList)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.AuthorID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Contract1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.ContractualID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.ContractAnnex)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.AuthorID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.ContractAnnex1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.AuthorID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Departments)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.HeadID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.HistoryChanges)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.AuthorID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Signing)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.SupAgreement)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.AuthorID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserPermissions)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserID);
        }
    }
}
