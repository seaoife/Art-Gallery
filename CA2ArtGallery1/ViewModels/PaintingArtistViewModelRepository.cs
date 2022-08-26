using CA2ArtGallery1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.ViewModels
{
    public class PaintingArtistViewModelRepository:IPaintingArtistViewModel
    {

        private readonly ApplicationDbContext _appDbContext;//instance of my database

        public PaintingArtistViewModelRepository(ApplicationDbContext appDbContext)//added in
        {
            _appDbContext = appDbContext;//added in
        }
        public IEnumerable<PaintingArtistViewModel> ListPaintingsDetails //=> throw new NotImplementedException();//function is not implmented.
        {
            get// COMMANDS to get things from teh database. below we have a query to get details from the database.
            {
                return _appDbContext.PaintingArtistViewModels;// choose any attributes of the class painting.
            }
        }


        //  IEnumerable is an interface and built datatype which is an interface. 

        public PaintingArtistViewModel ListPaintingsDetailsId(int Id)
        {
            return _appDbContext.PaintingArtistViewModels.Include(viewModelDetails => viewModelDetails.Id).FirstOrDefault(viewModelDetails => Id == viewModelDetails.Id);// Lamda expression which 
            //throw new NotImplementedException();
            //List<PaintingArtistViewModel> viewModelDetailsList = new List<PaintingArtistViewModel>();// made a list of our paintings.
            //Array.ForEach<PaintingArtistViewModel>(viewModelDetailsList.ToArray(), IteratePaintingsNames => Console.WriteLine(IteratePaintingsNames.PaintingArtistViewModel.Id));//listing all ids with a foreach in oneline. 
            //                                                                                                                      // Array.ForEach<Painting>(PaintingList.ToArray(), IteratePainting => IteratePainting.Id == Id);//listing all ids with a foreach in oneline. 
        }
    }
}

