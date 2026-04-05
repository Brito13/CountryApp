using countryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace countryApp.Controllers
{
    public class CountryController : Controller
    {
        List<Country> countries = new List<Country>
            {
                new Country { Name = "USA", Description = "United States of America", Code = "us" },
                new Country { Name = "Republica Dominicana", Description = "Country in North America", Code = "do" },
                new Country { Name = "Colombia", Description = "Country in North America", Code = "co"}
            };
        [Route("/")]
        public IActionResult Index(string? name)
        {
            if (name != null)
            {
                var countryQuery =
                    countries.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
                return View(countryQuery);
            }
            var country = countries;
            return View(countries);
        }
        //[Route("/buscar")]
    }
}
