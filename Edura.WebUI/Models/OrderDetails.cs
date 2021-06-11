using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Models
{
    public class OrderDetails
    {
        [Required(ErrorMessage ="Lüften bir adres tanımı giriniz")]
        public string AdresTanimi { get; set; }

        [Required(ErrorMessage = "Lüften bir adres giriniz")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Lüften bir şehir giriniz")]
        public string Sehir { get; set; }

        [Required(ErrorMessage = "Lüften bir semt giriniz")]
        public string Semt { get; set; }

        [Required(ErrorMessage = "Lüften bir telefon giriniz")]
        public string Telefon { get; set; }
    }
}
