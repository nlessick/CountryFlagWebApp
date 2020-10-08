using Microsoft.EntityFrameworkCore;

namespace CountryFlagWebApp.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "indoor", Name = "Indoor" },
                new Category { CategoryID = "outdoor", Name = "Outdoor" }
            );
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter", Name = "Winter Olympics" },
                new Game { GameID = "summer", Name = "Summer Olympics" },
                new Game { GameID = "paralympics", Name = "Paralympics"},
                new Game { GameID = "youth", Name = "Youth Olympic Games"}
            );
            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "aus", Name = "Austria", CategoryID = "outdoor", GameID = "paralympics", LogoImage = "Austria.png" },
                new { CountryID = "braz", Name = "Brazil", CategoryID = "outdoor", GameID = "summer", LogoImage = "Brazil.png" },
                new { CountryID = "can", Name = "Canada", CategoryID = "indoor", GameID = "winter", LogoImage = "Canada.png" },
                new { CountryID = "chi", Name = "China", CategoryID = "indoor", GameID = "summer", LogoImage = "China.png" },
                new { CountryID = "cyp", Name = "Cyprus", CategoryID = "indoor", GameID = "youth", LogoImage = "Cyprus.png" },
                new { CountryID = "fin", Name = "Finland", CategoryID = "outdoor", GameID = "youth", LogoImage = "Finland.png" },
                new { CountryID = "fra", Name = "France", CategoryID = "indoor", GameID = "youth", LogoImage = "France.png" },
                new { CountryID = "ger", Name = "Germany", CategoryID = "indoor", GameID = "summer", LogoImage = "Germany.png" },
                new { CountryID = "gb", Name = "Great Britain", CategoryID = "indoor", GameID = "winter", LogoImage = "GreatBritain.png" },
                new { CountryID = "ita", Name = "Italy", CategoryID = "outdoor", GameID = "winter", LogoImage = "Italy.png" },
                new { CountryID = "jam", Name = "Jamaica", CategoryID = "outdoor", GameID = "winter", LogoImage = "Jamaica.png" },
                new { CountryID = "jap", Name = "Japan", CategoryID = "outdoor", GameID = "winter", LogoImage = "Japan.png" },
                new { CountryID = "mex", Name = "Mexico", CategoryID = "indoor", GameID = "summer", LogoImage = "Mexico.png" },
                new { CountryID = "net", Name = "Netherlands", CategoryID = "outdoor", GameID = "summer", LogoImage = "Netherlands.png" },
                new { CountryID = "pak", Name = "Pakistan", CategoryID = "outdoor", GameID = "paralympics", LogoImage = "Pakistan.png" },
                new { CountryID = "por", Name = "Portugal", CategoryID = "outdoor", GameID = "youth", LogoImage = "Portugal.png" },
                new { CountryID = "rus", Name = "Russia", CategoryID = "indoor", GameID = "youth", LogoImage = "Russia.png" },
                new { CountryID = "slo", Name = "Slovakia", CategoryID = "outdoor", GameID = "youth", LogoImage = "Slovakia.png" },
                new { CountryID = "swe", Name = "Sweden", CategoryID = "indoor", GameID = "winter", LogoImage = "Sweden.png" },
                new { CountryID = "tha", Name = "Thailand", CategoryID = "indoor", GameID = "paralympics", LogoImage = "Thailand.png" },
                new { CountryID = "ukr", Name = "Ukraine", CategoryID = "indoor", GameID = "paralympics", LogoImage = "Ukraine.png" },
                new { CountryID = "uru", Name = "Uruguay", CategoryID = "indoor", GameID = "paralympics", LogoImage = "Uruguay.png" },
                new { CountryID = "usa", Name = "USA", CategoryID = "outdoor", GameID = "summer", LogoImage = "USA.png" },
                new { CountryID = "zim", Name = "Zimbabwe", CategoryID = "outdoor", GameID = "paralympics", LogoImage = "Zimbabwe.png" }
                );
        }
    }
}
