namespace NotificationSystem.Services.Location.Interface
{
    public interface ILocationService
    {
        string GetCountryByIP(string ip);
    }
}