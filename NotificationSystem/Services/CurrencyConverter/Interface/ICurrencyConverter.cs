using Data.Models;
using Data.Models.Converter;
using Data.Models.ExchangeList;

namespace NotificationSystem.Services.CurrencyConverter.Interface
{
    public interface ICurrencyConverter
    {
        JsonResponseConverter Convert(string addToUrl);
    }
}