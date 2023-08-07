namespace WebApplication1.Models
{
    public class DataService
    {
        List<Band> bands = new List<Band>
        {

         new Band {Id = 1, Name = "Post Malone", Description = "Hip Hop"},
         new Band {Id = 2, Name = "Hooja", Description = "Pop"},
         new Band {Id = 3, Name = "Lous and the Yakuza", Description = "R&B"},
         new Band {Id = 4, Name = "Wu-Tang Clan", Description = "Hip Hop"},
         new Band {Id = 5, Name = "Army Of The Pharaohs", Description = "Hip Hop"},

        };

        public Band GetBandById(int id)
        {
            return bands.SingleOrDefault(band => band.Id == id);
                
        }
        public Band[] GetAllBands()
        {
            return bands.ToArray();
        }
    }
}
