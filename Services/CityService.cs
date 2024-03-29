﻿using ServiceContracts;

namespace Services
{
    public class CityService : ICityService
    {

        private List<string> _cities;
        private Guid _guid;

        public CityService()
        {
            _cities = new List<string>();
            _guid = Guid.NewGuid();
        }

        public Guid Guid => _guid;

        public List<string> GetCities()
        {
            _cities.Add("Kolkata");
            _cities.Add("Mumbai");
            _cities.Add("Chennai");
            _cities.Add("Delhi");
            _cities.Add("Bengaluru");
            _cities.Add("Hyderabad");
            _cities.Add("Pune");
            _cities.Add("Gangtok");
            _cities.Add("Bolpur");
            _cities.Add("Dubrajpur");

            return _cities;
        }
    }
}
