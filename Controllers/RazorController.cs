using RazorNedir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorNedir.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
            List<Sinif> siniflar = new List<Sinif>();
            siniflar.Add(new Sinif { Id = 3, Ad = "Asp.Net 2" });
            siniflar.Add(new Sinif { Id = 4, Ad = "Asp.Net 3" });
            siniflar.Add(new Sinif { Id = 5, Ad = "Javascript" });

            ViewBag.Siniflar = siniflar;

            return View(new Ogrenci { Ad = "Ali Can", Soyad = "Ben", Id = 7, Adres = "Zeytinburnu", OgrenciNo = 107, SinifId = 3 });

        }
    }
}