using System.Data.Entity;
using VleisurePartner.Domain.Entities;

namespace VleisurePartner.Domain
{
    public interface IContext
    {
        DbSet<Region> Regions { get; set; }

        int SaveChanges();
        void SetCommandTimeout(int timeout);
        void SetRowStamp(object entity, byte[] rowStamp);
    }
}
