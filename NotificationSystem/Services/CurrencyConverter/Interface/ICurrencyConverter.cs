using Data.Models.Converter;

namespace NotificationSystem.Services.CurrencyConverter.Interface
{
    public interface ICurrencyConverter
    {
        JsonResponseConverter Convert(string addToUrl);
    }
}