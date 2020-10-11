using Microsoft.AspNetCore.Mvc;
using CountryFlagWebApp.Models;

namespace CountryFlagWebApp.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new CountrySession(HttpContext.Session);
            var model = new CountryListViewModel
            {
                ActiveCat = session.GetActiveCat(),
                ActiveGam = session.GetActiveGam(),
                Countries = session.GetMyCountries()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new CountrySession(HttpContext.Session);
            var cookies = new CountryCookies(Response.Cookies);

            session.RemoveMyCountries();
            cookies.RemoveMyCountryIds();

            TempData["message"] = "Favorite countries cleared";

            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveCat = session.GetActiveCat(),
                    ActiveGam = session.GetActiveGam()
                });
        }
    }
}
