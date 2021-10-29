namespace NotificationSystem.Settings
{
    public static class Settings
    {

        #region Currency List
        
        public const string ApiBearerCurrencyList = "05c8bff8c8b3abc4689e73ef8346244c"; // API key
        public const string ApiCurrencyListUrl = "https://api.kursna-lista.info/" + ApiBearerCurrencyList + "/kursna_lista/json";
        public const string ApiCurrencyConverterUrl = "https://api.kursna-lista.info/" + ApiBearerCurrencyList + "/konvertor/";
        

        #endregion

        #region Telegram

        public const string ApiBearerTelegram = "2074943559:AAGAbFIwBaQS7_pPcCE-db-swKHEXDkrtjo"; // API key
        public const int UserId = 2052493675;

        #endregion
    }
}