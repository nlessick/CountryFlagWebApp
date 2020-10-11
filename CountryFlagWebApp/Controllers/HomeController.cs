﻿using System;
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
            var session = new CountrySession(HttpContext.Session);
            session.SetActiveCat(activeCat);
            session.SetActiveGam(activeGam);

            // if no count value in session, use data in cookie to restore fave teams in session 
            int? count = session.GetMyCountryCount();
            if (count == null)
            {
                var cookies = new CountryCookies(Request.Cookies);
                string[] ids = cookies.GetMyCountryIds();

                List<Country> mycountries = new List<Country>();
                if (ids.Length > 0)
                    mycountries = context.Countries.Include(t => t.Category)
                        .Include(t => t.Game)
                        .Where(t => ids.Contains(t.CountryID)).ToList();
                session.SetMyCountries(mycountries);
            }

            var model = new CountryListViewModel
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
            model.Countries = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new CountrySession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(t => t.Category)
                    .Include(t => t.Game)
                    .FirstOrDefault(t => t.CountryID == id),
                ActiveGam = session.GetActiveGam(),
                ActiveCat = session.GetActiveCat()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Details(CountryViewModel model)
        {
            model.Country = context.Countries
                .Include(t => t.Category)
                .Include(t => t.Game)
                .Where(t => t.CountryID == model.Country.CountryID)
                .FirstOrDefault();

            var session = new CountrySession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            var cookies = new CountryCookies(Response.Cookies);
            cookies.SetMyCountryIds(countries);

            TempData["message"] = $"{model.Country.Name} added to your favorites";

            return RedirectToAction("Index",
                new
                {
                    ActiveCat = session.GetActiveCat(),
                    ActiveGam = session.GetActiveGam()
                });
        }
    }
}

