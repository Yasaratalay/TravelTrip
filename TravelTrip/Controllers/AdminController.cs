using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize] //Eğer sisteme giriş yapmamış birisi bu indexe gitmeye çalışırsa login ekranına atar. WebConfig içinde tanımlandı.
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            //Sayfa yüklendiğinde hiçbir şey yapma bana boş halini döndür
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            //Sayfada bir şey yaptığımda post yaptığımda burayı çalıştır
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SilBlog(int id)
        {
            var sil = c.Blogs.Find(id);
            c.Blogs.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGuncelle(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("BlogGuncelle", blog);
        }
        public ActionResult BlogGetir(Blog b)
        {
            var blg = c.Blogs.Find(b.Id);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;

            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var sil = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGuncelle(int id)
        {
            var yorum = c.Yorumlars.Find(id);
            return View("YorumGuncelle", yorum);
        }

        public ActionResult YorumGetir(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.Id);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Email = y.Email;
            yrm.Yorum = y.Yorum;

            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}