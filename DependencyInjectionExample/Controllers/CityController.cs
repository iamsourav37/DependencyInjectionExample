using Microsoft.AspNetCore.Mvc;
using Services;

namespace DependencyInjectionExample.Controllers
{
    public class CityController : Controller
    {

        private readonly CityService _cityService;

        public CityController()
        {
            _cityService = new CityService();
        }
        public IActionResult Index()
        {
            var listOfCities = _cityService.GetCities();

            return View(listOfCities);
        }
    }
}
