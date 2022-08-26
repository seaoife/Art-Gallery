using CA2ArtGallery1.Data;
using CA2ArtGallery1.Models;
using CA2ArtGallery1.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2ArtGallery1
{
    public class Startup
    {
        private const string TestUserPw = "Password@123";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            //services
            //    .AddIdentity<IdentityUser, IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services
                .AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            //.AddRoles<IdentityRole>(); // added roles
            services.AddControllersWithViews();
            services.AddScoped<IPainting, PaintingRepository>(); //register our own services, combining interface with the respository for teh controller. 
            services.AddScoped<IArtist, ArtistRepository>();// we cannot fetch data in the database unless it is registed in the start up. 
            services.AddScoped<IMediumUsed, MediumUsedRepository>();
            services.AddScoped<IStyle, StyleRepository>();
            services.AddScoped<IPaintingArtistViewModel, PaintingArtistViewModelRepository>();
            
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                   name: "gallery",
                   pattern: "{controller=Galleries}/{action=Greeting}");
                endpoints.MapControllerRoute(
                   name: "painting",
                   pattern: "{controller=Painting}/{action=Index}");
                endpoints.MapRazorPages();
            });

            AppDBInitializer.SeedUsersAndRolesAsync(app).Wait();//we are calling the appDBInitializer class which is the seeder class and save the login details for each role. 
        }
    }
}
