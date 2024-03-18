using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WestBengalCityService : ICityService
    {
        public List<string> GetCities()
        {
            return new List<string>()
            {
                "Kolkata", "Bolpur", "Darjeeling", "Jalpaiguri", "Durgapur", "Asansol"
            };
        }
    }
}
