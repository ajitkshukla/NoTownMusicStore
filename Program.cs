using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NoTownMusicalStore.Models;
using NoTownMusicalStore.Models.Repositories;
using NoTownMusicalStore.Models.Repositories.Implementation;
using NoTownMusicalStore.Models.Repositories.Interfaces;
using NoTownMusicalStore.Models.Services;

namespace NoTownMusicalStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IUserAuthenticationService, UserAuthenticationService>();

            builder.Services.AddScoped<MusicianRepository>();
            builder.Services.AddScoped<AlbumRepository>();
            builder.Services.AddScoped<SongRepository>();
            builder.Services.AddScoped<InstrumentRepository>();

            builder.Services.AddScoped<IAlbumService, AlbumService>();
            builder.Services.AddScoped<IMusicianService, MusicianService>();
            builder.Services.AddScoped<ISongService, SongService>();
            builder.Services.AddScoped<IFileService, FileService>();
            // builder.Services.AddScoped<LiveRepository>();
            //builder.Services.AddScoped<PlayRepository>();           
            builder.Services.AddScoped<IMusicStoreService, MusicStoreService>();
            builder.Services.AddScoped<IMusicStoreAdminService, MusicStoreAdminService>();


            builder.Services.AddDbContext<NoTownDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

            
            // For Identity
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<NoTownDbContext>()
                .AddDefaultTokenProviders();

            //builder.Services.ConfigureApplicationCookie(options => options.LoginPath = "/UserAuthentication/Login");

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}