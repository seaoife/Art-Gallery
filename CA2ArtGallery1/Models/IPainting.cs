using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Models
{
     public interface IPainting
    {

        IEnumerable<Painting> AllPaintings { get; }// define the function name and interface is alink between functions and actually implicating the function in the controller. 
        IEnumerable<Painting> AllPaintingsByStyleId(int StyleId);// we name teh function in the interface but the functionalty is actually deined in the respository.Define 
        Painting GetPaintingById(int Id);
    }
}
