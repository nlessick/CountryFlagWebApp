using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CountryFlagWebApp.Models;

namespace CountryFlagWebApp.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string activeCat = "all", string activeGam = "all")
        {
            var data = new CountryListViewModel
            {
                ActiveCat = activeCat,
                ActiveGam = activeGam,
                Categories = context.Categories.ToList(),
                Games = context.Games.ToList()
            };

            IQueryable<Country> query = context.Countries;
            if (activeCat != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == activeCat.ToLower());
            if (activeGam != "all")
                query = query.Where(
                    t => t.Game.GameID.ToLower() == activeGam.ToLower());
            data.Countries = query.ToList();

            return View(data);
        }

        [HttpPost]
        public IActionResult Details(CountryViewModel model)
        {
            Utility.LogCountryClick(model.Country.CountryID);

            TempData["ActiveCat"] = model.ActiveCat;
            TempData["ActiveGam"] = model.ActiveGam;
            return RedirectToAction("Details", new { ID = model.Country.CountryID });
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(t => t.Category)
                    .Include(t => t.Game)
                    .FirstOrDefault(t => t.CountryID == id),
                ActiveCat = TempData?["ActiveCat"]?.ToString() ?? "all",
                ActiveGam = TempData?["ActiveGam"]?.ToString() ?? "all"
            };
            return View(model);
        }
    }
}
