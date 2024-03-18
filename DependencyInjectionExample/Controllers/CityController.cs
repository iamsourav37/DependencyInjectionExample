using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionExample.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
