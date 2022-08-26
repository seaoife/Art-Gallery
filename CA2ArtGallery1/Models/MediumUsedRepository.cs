using CA2ArtGallery1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Models
{
    public class MediumUsedRepository:IMediumUsed
    {
        private readonly ApplicationDbContext _appDbContext;//instance of my database

        public  MediumUsedRepository(ApplicationDbContext appDbContext)//added in
        {
            _appDbContext = appDbContext;//added in
        }
        public IEnumerable<MediumUsed> AllMediums //=> throw new NotImplementedException();//function is not implmented.
        {
            get
            {
                return _appDbContext.MediumUseds.Include(mediumDetails => mediumDetails.MediumUsedId);// choose any attributes of the class painting.
            }
        }

       
        public MediumUsed GetMediumUsedById(int Id)
        {
            return _appDbContext.MediumUseds.Include(mediumDetails => mediumDetails.MediumUsedName).FirstOrDefault(mediumDetails => Id == mediumDetails.MediumUsedId);// Lamda expression which 
            //throw new NotImplementedException();
            List<MediumUsed> MediumUsedList = new List<MediumUsed>();// made a list of our paintings.
            Array.ForEach<MediumUsed>(MediumUsedList.ToArray(), IterateMediums => Console.WriteLine(IterateMediums.MediumUsedId));//listing all ids with a foreach in oneline. 
                                                                                                                      // Array.ForEach<Painting>(PaintingList.ToArray(), IteratePainting => IteratePainting.Id == Id);//listing all ids with a foreach in oneline. 
        }
    }
}
