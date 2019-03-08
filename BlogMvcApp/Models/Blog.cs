using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string Icerik { get; set; }
        public DateTime EklemeTarihi { get; set; }//  DateTime? varsayilan degeri gondermesin girmessek
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }

        public int CategoryId { get; set; } //tabloda gorulecek
        public Category Category { get; set; } //iliski kurmak icin(gecis degeri)

    }
}