using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MetropolitonCityService : ICityService
    {
        private Guid _guid;

        public MetropolitonCityService()
        {
            _guid = Guid.NewGuid();
        }
        public Guid Guid => _guid;

        public List<string> GetCities()
        {
            return new List<string>()
            {
                "Kolkata", "Mumbai", "Bengalore", "Chennai"
            };
        }
    }
}
