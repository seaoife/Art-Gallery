using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.ViewModels
{
    public interface IPaintingArtistViewModel
    {

       IEnumerable<PaintingArtistViewModel> ListPaintingsDetails { get; }// Interface in this case is used to link to the database.
        PaintingArtistViewModel ListPaintingsDetailsId(int Id); //should have the same return types for the repository funcions, same names eg ListPaintingsDetailsId(int Id)
    }
}// acessing the instqnces of teh clsses in the repositories. 
