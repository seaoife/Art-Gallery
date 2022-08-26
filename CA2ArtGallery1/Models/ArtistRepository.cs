using CA2ArtGallery1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Models
{
    public class ArtistRepository:IArtist
    {

        private readonly ApplicationDbContext _appDbContext;//instance of my database

        public ArtistRepository(ApplicationDbContext appDbContext)//a respot
        {
            _appDbContext = appDbContext;//added in
        }


        public IEnumerable<Artist> AllArtists //=> throw new NotImplementedException();//function is not implmented.
        {
            get
            {
                return _appDbContext.Artists.Include(ArtistDetails => ArtistDetails.FirstName);// choose any attributes of the class painting.
            }
        }

        public Artist GetArtistById(int Id)
        {
            return _appDbContext.Artists.Include(artistDetails => artistDetails.SurName).FirstOrDefault(artistDetails => Id == artistDetails.Id);// Lamda expression which 
            //throw new NotImplementedException();
            //List<Artist> ArtistList = new List<Artist>();// made a list of our paintings.
            //Array.ForEach<Artist>(ArtistList.ToArray(), IterateArtists => Console.WriteLine(IterateArtists.Id));//listing all ids with a foreach in oneline. 
                                                                                                                      // Array.ForEach<Painting>(PaintingList.ToArray(), IteratePainting => IteratePainting.Id == Id);//listing all ids with a foreach in oneline. 
        }
    }
}
