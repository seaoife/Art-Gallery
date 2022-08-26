using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Models
{
   public  interface IMediumUsed
    {
        IEnumerable<MediumUsed> AllMediums { get; }
        MediumUsed GetMediumUsedById(int Id);
    }
}
