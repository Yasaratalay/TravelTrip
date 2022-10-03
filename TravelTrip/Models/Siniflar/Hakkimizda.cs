using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int Id { get; set; }
        public string FotografUrl { get; set; }
        public string Aciklama { get; set; }
    }
}