namespace Data.Models.User
{
    public class User
    {
        private static User _instance;
        
        public int LanguageId { get; set; }
        public string Currency { get; set; }

        public static User Instance => _instance is null ? _instance = new User() : _instance; //singleton

        public User()
        {
            LanguageId = 0; //en
            Currency = "eur";// currency from users country
        }
        
    }
}