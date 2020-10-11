using System.Collections.Generic;

namespace CountryFlagWebApp.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public List<Country> Countries { get; set; }

         //use full properties for Categories and Games
         //so can add 'All' item at beginning
        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = new List<Category>
                {
                    new Category {CategoryID = "all", Name = "All"}
                };
                categories.AddRange(value);
            }
        }

        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = new List<Game>
                {
                    new Game { GameID = "all", Name = "All"}
                };
                games.AddRange(value);
            }
        }

         //methods to help view determine active link
        public string CheckActiveCat(string c) =>
            c.ToLower() == ActiveCat.ToLower() ? "active" : "";

        public string CheckActiveGam(string g) =>
            g.ToLower() == ActiveGam.ToLower() ? "active" : "";
    
    }
}
