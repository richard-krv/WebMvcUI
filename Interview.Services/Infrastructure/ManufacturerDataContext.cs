using System.Data.Entity;
using Interview.Services.DataModels;

namespace Interview.Services.Infrastructure
{
    public class ManufacturerDataContext : DbContext
    {
        public ManufacturerDataContext(string connectionString) : base(connectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().ToTable("Manufacturer", "dbo");
            modelBuilder.Entity<Range>().ToTable("Range", "dbo");

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Range> Ranges { get; set; }
    }
}
