using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorNedir.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public int OgrenciNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public int SinifId { get; set; }
    }
}