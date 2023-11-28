using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NoTownMusicalStore.Models.Entities;
using NoTownMusicalStore.Models.ViewModels;


namespace NoTownMusicalStore.Models
{
    public class NoTownDbContext : IdentityDbContext<ApplicationUser>
    {
        public NoTownDbContext(DbContextOptions<NoTownDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            
    }

        public DbSet<Musician> Musicians { get; set; } 
        public DbSet<Instrument> Instruments { get; set; }      
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumMusician> AlbumMusicians { get; set; }
        //public DbSet<AlbumProducer> AlbumProducers { get; set; }
        public DbSet<AlbumSong> AlbumSongs { get; set; }
        public DbSet<SongMusician> SongMusicians { get; set; }
        //public DbSet<Play> Plays { get; set; }
        //public DbSet<Live> Lives { get; set; }
        public DbSet<NoTownMusicalStore.Models.ViewModels.AddMusicianViewModel>? AddMusicianViewModel { get; set; }
        public DbSet<NoTownMusicalStore.Models.ViewModels.AddAlbumViewModel>? AddAlbumViewModel { get; set; }
    }
}
