namespace Data.Models.Converter
{
    public class JsonResponseConverter
    {
        public Result result { get; set; }
        public int code { get; set; }
        public string status { get; set; }
    }
}