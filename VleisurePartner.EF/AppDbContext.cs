using System.Data.Entity;
using VleisurePartner.Domain;
using VleisurePartner.Domain.Entities;
using VleisurePartner.EF.Configurations;

namespace VleisurePartner.EF
{
    public class AppDbContext : DbContext, IContext
    {
        public System.Data.Entity.DbSet<Region> Regions { get; set; } // Region

        public AppDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new RegionConfiguration());
        }

        public void SetCommandTimeout(int timeout)
        {
            Database.CommandTimeout = timeout;
        }

        public void SetRowStamp(object entity, byte[] rowStamp)
        {
            Entry(entity).Property("RowStamp").OriginalValue = rowStamp;
        }
    }
}