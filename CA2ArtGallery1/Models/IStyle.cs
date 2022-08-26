using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Models
{
   public interface IStyle

    {
        IEnumerable<Style> AllStyles { get;}
        Style GetStyleById(int Id);

    }
}
