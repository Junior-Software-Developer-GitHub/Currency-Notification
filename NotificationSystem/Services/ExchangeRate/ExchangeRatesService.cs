using System;
using System.IO;
using System.Net;
using System.Text.Json;
using Data.Models.ExchangeList;
using Microsoft.AspNetCore.Server.IIS.Core;
using NotificationSystem.Services.ExchangeRate.Interfaces;

namespace NotificationSystem.Services.ExchangeRate
{
    public class ExchangeRatesService : IExchangeRatesService
    {
        public JsonResponseExchangeList GetExchangeRates()
        {
            try
            {
                WebRequest request = WebRequest.Create(Settings.Settings.ApiCurrencyListUrl);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream() ?? new ThrowingWasUpgradedWriteOnlyStream());
                
                return JsonSerializer.Deserialize<JsonResponseExchangeList>(reader.ReadToEnd(), new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}