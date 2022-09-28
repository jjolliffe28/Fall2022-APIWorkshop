using Fall2022_APIWorkshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Fall2022_APIWorkshop
{
    public class VideoGameContext :DbContext
    {
        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<MainCharacter> MainCharacters { get; set; }
        public DbSet<Studio> Studios { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=VGDB_example;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Studio>().HasData(
                new Studio() { Id = 1, Name = "Nintendo", EmployeeCount = 6717 },
                new Studio() { Id = 2, Name = "Hal Laboratories", EmployeeCount = 202});
            model.Entity<VideoGame>().HasData(
                new VideoGame() { Id = 1, Title = "Super Mario Brothers", StudioId = 1}, 
                new VideoGame() { Id = 2, Title = "Kirby: Nightmare in Dreamland", StudioId = 2},
                new VideoGame() { Id = 3, Title = "Pikmin", StudioId = 1});

            model.Entity<MainCharacter>().HasData(
                new MainCharacter() { Id = 1, Name = "Mario", VideoGameId = 1},
                new MainCharacter() { Id = 2, Name = "Kirby", VideoGameId = 2},
                new MainCharacter() { Id = 3, Name = "Captain Olimar", VideoGameId = 3});
        }
    }
}

// add-migration Name
// update-database