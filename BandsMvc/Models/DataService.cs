using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1.Models
{
    public class DataService
    {
        List<Band> bands = new List<Band>
		{

         new Band {Id = 1, Name = "Post Malone", Description = "Hip Hop", ImagePath="/images/PM.jpg"},
         new Band {Id = 2, Name = "Hooja", Description = "Pop",  ImagePath="/images/Hooja.jpg"},
		 new Band {Id = 3, Name = "Lous and the Yakuza", Description = "R&B",  ImagePath="/images/LousYakuza.jpg"},
         new Band {Id = 4, Name = "Wu-Tang Clan", Description = "Hip Hop",  ImagePath="/images/WuTangClan.jpg"},
         new Band {Id = 5, Name = "Army Of The Pharaohs", Description = "Hip Hop",  ImagePath="/images/Army.jpg"},
         
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
