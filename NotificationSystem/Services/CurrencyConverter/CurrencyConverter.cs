using System;
using System.IO;
using System.Net;
using System.Text.Json;
using Data.Models.Converter;
using Microsoft.AspNetCore.Server.IIS.Core;
using NotificationSystem.Services.CurrencyConverter.Interface;

namespace NotificationSystem.Services.CurrencyConverter
{
    public class CurrencyConverter : ICurrencyConverter
    {
        public JsonResponseConverter Convert(string addToUrl)
        {
            try
            {
                WebRequest request = WebRequest.Create(Settings.Settings.ApiCurrencyConverterUrl + addToUrl);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream() ?? new ThrowingWasUpgradedWriteOnlyStream());
                
                return JsonSerializer.Deserialize<JsonResponseConverter>(reader.ReadToEnd(), new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}