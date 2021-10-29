using Data.Models.ExchangeList;

namespace NotificationSystem.Services.ExchangeRate.Interfaces
{
    public interface IExchangeRatesService
    {
        JsonResponseExchangeList GetExchangeRates();
    }
}