using CA2ArtGallery1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Models
{
    public class PaintingRepository : IPainting

    {
        private readonly ApplicationDbContext _appDbContext;//instance of my database

        public PaintingRepository(ApplicationDbContext appDbContext)//a repsoitory is a data source for the painting model. for each model we have a respository. 
        {// the cide is more maintaintable with teh repository and you do not have to change the controller code but just in the repository.
            _appDbContext = appDbContext;//added in
        }


        public IEnumerable<Painting> AllPaintings //=> the ienumeruable (list) is an instance of the . the function will return a list of paintings. 
        {
            get
            {
                return _appDbContext// the return is fetching from the database. and including the other models. ids of teh models are in the datatalbe as secondary keys. 
                    .Paintings
                    .Include(m => m.Artist)
                    .Include(m => m.Style)
                    .Include(m => m.MediumUsed);

                // to correct the error instnace of the class was null, we needed to include the info in the artist table. 
            }
      
        }

        public IEnumerable<Painting> AllPaintingsByStyleId(int StyleId) //=> throw new NotImplementedException();
        {
            
               return _appDbContext
                    .Paintings
                    .Include(m => m.Artist)
                    .Include(m => m.Style)
                    .Include(m => m.MediumUsed)
                    .Where(p => p.Style.StyleId == StyleId);// this function gets all paintsin using style id.

                // to correct the error instnace of the class was null, we needed to include the info in the artist table. 
           

        }

        public Painting GetPaintingById(int Id)
        {
            return _appDbContext.Paintings
                .Include(p => p.Artist)
                .Include(m => m.Style)
                .Include(m => m.MediumUsed)
                .FirstOrDefault(paintingDetails => Id == paintingDetails.Id);// Lamda expression is selecting the painting where the id of that painting matches the id of the painting that we are receiving in this fucntion.
            //throw new NotImplementedException();
           /* List<Painting> PaintingList = new List<Painting>();// made*//* a list of our paintings.*/
                                                               //    Array.ForEach<Painting>(PaintingList.ToArray(), IteratePainting => (IteratePainting.Id));//listing all ids with a foreach in oneline. 
                                                               //   // Array.ForEach<Painting>(PaintingList.ToArray(), IteratePainting => IteratePainting.Id == Id);//listing all ids with a foreach in oneline. 
                                                               //}
        }
    
    }
}
