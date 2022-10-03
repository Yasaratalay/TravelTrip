using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class GirisYapController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            //Böyle bir kullanıcı var mı?
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View(); // böyle kullanıcı yoksa aynı sayfayı tekrar gönder
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }
    }
}