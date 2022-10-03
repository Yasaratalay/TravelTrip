using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Siniflar
{
    public class BlogYorum
    {
        // Bir View içerisinde birden fazla tablodan veri çekebilmek için.
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}