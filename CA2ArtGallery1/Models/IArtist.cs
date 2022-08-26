using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Models
{
   public  interface IArtist
    {
        IEnumerable<Artist> AllArtists { get; }
        Artist GetArtistById(int Id);
    }
}
