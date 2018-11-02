namespace Komis.Models
{
    public class OpiniaRepository : IOpiniaRpository
    {
        private readonly AppDbContext appDbContext;

        public OpiniaRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void DodajOpinie(Opinia opinia)
        {
            appDbContext.Opinie.Add(opinia);
            appDbContext.SaveChanges();
        }
    }
}
