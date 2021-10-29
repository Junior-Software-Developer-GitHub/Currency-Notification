using System.Globalization;
using System.Net;
using Newtonsoft.Json;
using NotificationSystem.Services.Location.Interface;
using NotificationSystem.Services.Location.Model;

namespace NotificationSystem.Services.Location
{
    public class LocationService : ILocationService
    {
        public string GetCountryByIP(string ip)
        {
            IpInfo ipInfo = new IpInfo();
            ipInfo = JsonConvert.DeserializeObject<IpInfo>(new WebClient().DownloadString("http://ipinfo.io/" + ip));

            return new RegionInfo(ipInfo!.Country).ToString();
            
        }
    }
}