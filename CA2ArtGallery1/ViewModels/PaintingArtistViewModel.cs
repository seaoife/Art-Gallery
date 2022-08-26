using CA2ArtGallery1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.ViewModels
{
    public class PaintingArtistViewModel
    {
        public int  Id { get; set; }
        public Painting thisPainting { get; set; }
        public Artist thisArtist { get; set; }
       
    }
}
