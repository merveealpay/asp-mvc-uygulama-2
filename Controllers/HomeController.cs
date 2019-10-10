using RazorNedir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorNedir.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            #region kullanılacak datalar oluşturuluyor
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci { Ad = "Merve", Soyad = "Alpay", Id = 1, Adres = "Bağcılar", OgrenciNo = 101, SinifId = 4 });
            ogrenciler.Add(new Ogrenci { Ad = "Reşmi", Soyad = "İsmailov", Id = 2, Adres = "Küçükçekmece", OgrenciNo = 102, SinifId = 4 });
            ogrenciler.Add(new Ogrenci { Ad = "Merve", Soyad = "Başkan", Id = 3, Adres = "Sancaktepe", OgrenciNo = 103, SinifId = 5 });
            ogrenciler.Add(new Ogrenci { Ad = "Yusuf Ziya", Soyad = "Tüzün", Id = 4, Adres = "Esenyurt", OgrenciNo = 104, SinifId = 5 });
            ogrenciler.Add(new Ogrenci { Ad = "Sercan", Soyad = "Tırmık", Id = 5, Adres = "Küçükçekmece", OgrenciNo = 105, SinifId = 3 });
            ogrenciler.Add(new Ogrenci { Ad = "Ezgi", Soyad = "Aygün", Id = 6, Adres = "Ayazağa", OgrenciNo = 106, SinifId = 3 });
            ogrenciler.Add(new Ogrenci { Ad = "Ali Can", Soyad = "Ben", Id = 7, Adres = "Zeytinburnu", OgrenciNo = 107, SinifId = 3 });

            List<Sinif> siniflar = new List<Sinif>();
            siniflar.Add(new Sinif { Id = 3, Ad = "Asp.Net 2" });
            siniflar.Add(new Sinif { Id = 4, Ad = "Asp.Net 3" });
            siniflar.Add(new Sinif { Id = 5, Ad = "Javascript" }); 
            #endregion

            return View(new Tuple<List<Ogrenci>, List<Sinif>,string>(ogrenciler,siniflar, "Data gönderildi."));
        }

        public ActionResult Sinif(int id)
        {
            #region kullanılacak datalar oluşturuluyor
            List<Sinif> siniflar = new List<Sinif>();
            siniflar.Add(new Sinif { Id = 3, Ad = "Asp.Net 2" });
            siniflar.Add(new Sinif { Id = 4, Ad = "Asp.Net 3" });
            siniflar.Add(new Sinif { Id = 5, Ad = "Javascript" });

            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci { Ad = "Merve", Soyad = "Alpay", Id = 1, Adres = "Bağcılar", OgrenciNo = 101, SinifId = 4 });
            ogrenciler.Add(new Ogrenci { Ad = "Reşmi", Soyad = "İsmailov", Id = 2, Adres = "Küçükçekmece", OgrenciNo = 102, SinifId = 4 });
            ogrenciler.Add(new Ogrenci { Ad = "Merve", Soyad = "Başkan", Id = 3, Adres = "Sancaktepe", OgrenciNo = 103, SinifId = 5 });
            ogrenciler.Add(new Ogrenci { Ad = "Yusuf Ziya", Soyad = "Tüzün", Id = 4, Adres = "Esenyurt", OgrenciNo = 104, SinifId = 5 });
            ogrenciler.Add(new Ogrenci { Ad = "Sercan", Soyad = "Tırmık", Id = 5, Adres = "Küçükçekmece", OgrenciNo = 105, SinifId = 3 });
            ogrenciler.Add(new Ogrenci { Ad = "Ezgi", Soyad = "Aygün", Id = 6, Adres = "Ayazağa", OgrenciNo = 106, SinifId = 3 });
            ogrenciler.Add(new Ogrenci { Ad = "Ali Can", Soyad = "Ben", Id = 7, Adres = "Zeytinburnu", OgrenciNo = 107, SinifId = 3 }); 
            #endregion

            List<Ogrenci> sinifinOgrencileri = ogrenciler.Where(x => x.SinifId == id).ToList();
            ViewBag.Siniflar = siniflar;

            return View(sinifinOgrencileri);
        }

        public PartialViewResult BilgiPartial()
        {
            TempData["bilgi"] = "Geçici bilgiyi gönderiyoruz";
            return PartialView();
        }
    }
}