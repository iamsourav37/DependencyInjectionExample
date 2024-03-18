namespace Services
{
    public class CityService
    {

        private List<string> _cities;

        public CityService()
        {
            _cities = new List<string>();
        }
        public List<string> GetCities()
        {
            _cities.Add("Kolkata");
            _cities.Add("Mumbai");
            _cities.Add("Chennai");
            _cities.Add("Delhi");
            _cities.Add("Bengaluru");
            _cities.Add("Hyderabad");

            return _cities;
        }
    }
}
