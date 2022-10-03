using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Yorum { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}