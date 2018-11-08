namespace VleisurePartner.Domain
{
    public interface IContext
    {
        //IDbSet<Accpac> Accpacs { get; set; } // Accpac

        int SaveChanges();
        void SetCommandTimeout(int timeout);
        void SetRowStamp(object entity, byte[] rowStamp);
    }
}
