using System.ComponentModel.DataAnnotations;

namespace WEBODEVI.Models
{
    public class Uye
    {

        public int UyeID { get; set; }
        public string? UyeAd { get; set; }
        public string? UyeSoyad { get; set; }
        public string? UyeMail { get; set; }
        public string? UyeSifre { get; set; }
    }
}
