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
        private Guid _guid;
        public WestBengalCityService()
        {
            _guid = Guid.NewGuid();
        }

        public Guid Guid => _guid;

        public List<string> GetCities()
        {
            return new List<string>()
            {
                "Kolkata", "Bolpur", "Darjeeling", "Jalpaiguri", "Durgapur", "Asansol"
            };
        }
    }
}
