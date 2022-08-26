using CA2ArtGallery1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Models
{
    public class StyleRepository:IStyle
    {
        private readonly ApplicationDbContext _appDbContext;//instance of my database

        public StyleRepository(ApplicationDbContext appDbContext)//added in
        {
            _appDbContext = appDbContext;//added in
        }


        public IEnumerable<Style> AllStyles //=> throw new NotImplementedException();//function is not implmented.
        {
            get
            {
                return _appDbContext.Styles;// choose any attributes of the class painting.
            }
        }

        public Style GetStyleById(int Id)
        {
            return _appDbContext.Styles.Include(styleDetails => styleDetails.StyleName).FirstOrDefault(paintingDetails => Id == paintingDetails.StyleId);// Lamda expression which 
            //throw new NotImplementedException();
            List<Painting> PaintingList = new List<Painting>();// made a list of our paintings.
            Array.ForEach<Painting>(PaintingList.ToArray(), IteratePainting => Console.WriteLine(IteratePainting.Id));//listing all ids with a foreach in oneline. 
                                                                                                                      // Array.ForEach<Painting>(PaintingList.ToArray(), IteratePainting => IteratePainting.Id == Id);//listing all ids with a foreach in oneline. 
        }
    }
}
