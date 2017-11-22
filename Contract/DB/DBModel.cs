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
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<ContractCategory> ContractCategory { get; set; }
        public virtual DbSet<ContractExtension> ContractExtension { get; set; }
        public virtual DbSet<ContractExtensionPeriod> ContractExtensionPeriod { get; set; }
        public virtual DbSet<Contractors> Contractors { get; set; }
        public virtual DbSet<ContractorType> ContractorType { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<HistoryChanges> HistoryChanges { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Signing> Signing { get; set; }
        public virtual DbSet<SupAgreement> SupAgreement { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UserPermissions> UserPermissions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractCategory>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.ContractCategory)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<ContractExtensionPeriod>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.ContractExtensionPeriod)
                .HasForeignKey(e => e.ContractExtensionTimeID);

            modelBuilder.Entity<Contractors>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.Contractors)
                .HasForeignKey(e => e.ContractorID);

            modelBuilder.Entity<ContractorType>()
                .HasMany(e => e.Contractors)
                .WithOptional(e => e.ContractorType)
                .HasForeignKey(e => e.TypeID);

            modelBuilder.Entity<Departments>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.Departments)
                .HasForeignKey(e => e.DepartmentID);

            modelBuilder.Entity<Departments>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.Departments1)
                .HasForeignKey(e => e.DepartmentID);

            modelBuilder.Entity<Permissions>()
                .HasMany(e => e.UserPermissions)
                .WithOptional(e => e.Permissions)
                .HasForeignKey(e => e.PermissionID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.AuthorID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Contract1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.ContractualID);

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
