namespace WEBODEVI.Models
{
    public class Cars
    {
        public int ID { get; set; }
        public string? CarBrand { get; set; }
        public string? CarModel { get; set; }
        public int CarHourPrice { get; set; }
        public int CarDayPrice { get; set; }    
        public int CarMonthPrice { get; set;}
        public string? CarPhoto { get; set; }
    }
}
