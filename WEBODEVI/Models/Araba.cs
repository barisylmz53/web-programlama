using System.ComponentModel.DataAnnotations;

namespace WEBODEVI.Models
{
    public class Araba
    {
        [Key]
        public int CarID { get; set; }
        public string? CarBrand { get; set; }
        public string? CarModel { get; set; }
        public int CarPrice { get; set; }
        public string? CarPhoto { get; set; }
    }
}
