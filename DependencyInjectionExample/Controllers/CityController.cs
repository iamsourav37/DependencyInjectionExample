using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace DependencyInjectionExample.Controllers
{
    public class CityController : Controller
    {

        private readonly ICityService _cityService;
        private readonly ICityService _cityService2;
        private readonly ICityService _cityService3;

        public CityController(ICityService cityService, ICityService cityService2, ICityService cityService3)
        {
            _cityService = cityService;
            _cityService2 = cityService2;
            _cityService3 = cityService3;
        }
        public IActionResult Index()
        {
            var listOfCities = _cityService.GetCities();
            ViewBag.Guid = _cityService.Guid;
            ViewBag.Guid2 = _cityService2.Guid;
            ViewBag.Guid3 = _cityService3.Guid;

            return View(listOfCities);
        }
    }
}
