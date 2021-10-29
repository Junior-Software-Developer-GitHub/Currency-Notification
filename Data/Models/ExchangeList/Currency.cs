using System;

namespace Data.Models.ExchangeList
{
    public class Currency
    {
        public string kup { get; set; }
        public string sre { get; set; }
        public string pro { get; set; }

        public Currency()
        {
            kup = sre = pro = String.Empty;
        }
    }
}