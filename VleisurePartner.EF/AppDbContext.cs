using System.Data.Entity;
using VleisurePartner.Domain;

namespace VleisurePartner.EF
{
    public class AppDbContext : DbContext, IContext
    {
        //public IDbSet<Accpac> Accpacs { get; set; } // Accpac

        public AppDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Configurations.Add(new AccpacConfiguration());
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