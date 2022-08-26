using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1.Models
{
   
        public class PaintingViewModel// put in capitlas as they are part of the class Painting.
        {
            public int Id { get; set; }
            public int ArtistId { get; set; }
            public string Title { get; set; }
            public int MediumUsedId { get; set; }

            public int StyleId { get; set; }
            public string Subject { get; set; }

            public int Height { get; set; }// in mm
            public int Length { get; set; }// in mm
            public int Width { get; set; }// in mm
            public bool Framed { get; set; }
            public string Description { get; set; }

            public float Price { get; set; }
            public IFormFile Image { get; set; }

            public string AlternateText { get; set; }
            public DateTime UploadDate { get; set; }

            public Artist Artist{ get; set; }

            public MediumUsed MediumUsed { get; set; }

            public Style Style { get; set; }

}



    

}

