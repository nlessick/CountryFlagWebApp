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
                categories = value;
                categories.Insert(0, new Category { CategoryID = "all", Name = "All" });
            }
        }

        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0, new Game { GameID = "all", Name = "All" });
            }
        }

         //methods to help view determine active link
        public string CheckActiveCat(string c) =>
            c.ToLower() == ActiveCat.ToLower() ? "active" : "";

        public string CheckActiveGam(string g) =>
            g.ToLower() == ActiveGam.ToLower() ? "active" : "";
    
    }
}
