namespace ServiceContracts
{
    public interface ICityService
    {
        Guid Guid { get; }
        List<string> GetCities();
    }
}
