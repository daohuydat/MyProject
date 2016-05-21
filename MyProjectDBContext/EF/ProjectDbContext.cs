namespace MyProjectDBContext.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProjectDbContext : DbContext
    {
        public ProjectDbContext()
            : base("name=AzureDbContext")
        {
        }

        public virtual DbSet<AdvisorDomain> AdvisorDomains { get; set; }
        public virtual DbSet<Advisor> Advisors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdvisorDomain>()
                .HasMany(e => e.Advisors)
                .WithRequired(e => e.AdvisorDomain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.ProfileImage)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.IDImageFront)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.IDImageBack)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Advisor>()
                .Property(e => e.Status)
                .IsUnicode(false);
        }
    }
}
