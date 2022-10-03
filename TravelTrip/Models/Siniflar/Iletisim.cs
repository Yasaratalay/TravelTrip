using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Siniflar
{
    public class Iletisim
    {
        [Key]
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}