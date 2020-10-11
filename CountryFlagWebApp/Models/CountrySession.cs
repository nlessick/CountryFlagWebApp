using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace CountryFlagWebApp.Models
{
    public class CountrySession
    {
        private const string CountriesKey = "mycountries";
        private const string CountKey = "countrycount";
        private const string CatKey = "cat";
        private const string GamKey = "gam";

        private ISession session { get; set; }
        public CountrySession(ISession session)
        {
            this.session = session;
        }

        public void SetMyCountries(List<Country> countries)
        {
            session.SetObject(CountriesKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }
        public List<Country> GetMyCountries() =>
            session.GetObject<List<Country>>(CountriesKey) ?? new List<Country>();
        public int? GetMyCountryCount() => session.GetInt32(CountKey);

        public void SetActiveCat(string category) =>
            session.SetString(CatKey, category);
        public string GetActiveCat() => session.GetString(CatKey);

        public void SetActiveGam(string game) =>
            session.SetString(GamKey, game);
        public string GetActiveGam() => session.GetString(GamKey);

        public void RemoveMyCountries()
        {
            session.Remove(CountriesKey);
            session.Remove(CountKey);
        }
    }
}
