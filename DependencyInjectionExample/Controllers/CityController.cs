using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace DependencyInjectionExample.Controllers
{
    public class CityController : Controller
    {

        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        public IActionResult Index()
        {
            var listOfCities = _cityService.GetCities();

            return View(listOfCities);
        }
    }
}
