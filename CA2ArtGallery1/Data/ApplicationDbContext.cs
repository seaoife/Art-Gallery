using CA2ArtGallery1.Models;
using CA2ArtGallery1.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA2ArtGallery1.Data
{
    public class ApplicationDbContext : IdentityDbContext // build in parent class to c sharp
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Painting> Paintings { get; set; }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<MediumUsed> MediumUseds { get; set; }
        public DbSet<Style> Styles { get; set; }

        public DbSet<PaintingArtistViewModel> PaintingArtistViewModels { get; set; }

    }
}
