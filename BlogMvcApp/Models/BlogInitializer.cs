using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    { //veritabanibanimizda degisilik yaptigimizda  silip tekrar olusturulacak

        //olusacak olan veritabani (BlogMvcApp.Models.BlogContext)

        protected override void Seed(BlogContext context)
        {
            //test verileri

            List<Category> kategoriler = new List<Category>()
            {
                new Category(){ KategoriAdi="C#"},
                new Category(){  KategoriAdi="Asp.net MVC" },
                new Category(){  KategoriAdi="Asp.net web" },
                new Category(){  KategoriAdi="Windows Form" }

            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item); //kategorileri ekliyoruz
            }
            context.SaveChanges(); //kaydediyoruz

            List<Blog> Bloglar = new List<Blog>()
            {
                new Blog() { Baslik="C# Generic listler C# Generic listlerC# Generic listlerC# Generic listler C# Generic listler C# Generic listler C# Generic listler C# Generic listler   C# Generic listler C# C# Generic listler C# C# Generic listler C# C# Generic listler C#       C# Generic listler C# C# Generic listler C# C# Generic listler C#    ",EklemeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true,Onay=true,Aciklama="dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",Resim="1.jpg",CategoryId=1
                },
                 new Blog() { Baslik="C# Generic listler",EklemeTarihi=DateTime.Now.AddDays(-50), Anasayfa=true,Onay=true,Aciklama="dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış.",Resim="2.jpg",CategoryId=2
                },
                  new Blog() { Baslik="C# Generic listler",EklemeTarihi=DateTime.Now.AddDays(-20), Anasayfa=false,Onay=true,Aciklama="dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır",Resim="3.jpg",CategoryId=3
                },
                  new Blog() { Baslik="C# Generic listler",EklemeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true,Onay=true,Aciklama="dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır",Resim="3.jpg",CategoryId=3
                },
                  new Blog() { Baslik="C# Generic listler",EklemeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true,Onay=true,Aciklama="dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir",Resim="4.jpg",CategoryId=4
                },
                  new Blog() { Baslik="C# Generic listler",EklemeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true,Onay=false,Aciklama="dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış.",Resim="2.jpg",CategoryId=2
                },
                   new Blog() { Baslik="C# Generic listler",EklemeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true,Onay=true,Aciklama="dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",Resim="1.jpg",CategoryId=1
                },
                   new Blog() { Baslik="C# Delegates C# Delegates C# Delegates C# Delegates C# Delegates C# Delegates C# Delegates C# Delegates C# Delegates  C# Delegates ",EklemeTarihi=DateTime.Now.AddDays(-5), Anasayfa=false,Onay=true,Aciklama="dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir",Resim="4.jpg",CategoryId=4
                },
                    new Blog() { Baslik="C# Delegates",EklemeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true,Onay=true,Aciklama="dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir",Resim="4.jpg",CategoryId=4
                },
                     new Blog() { Baslik="C# Generic listler",EklemeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true,Onay=false,Aciklama="dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",Resim="1.jpg",CategoryId=1
                }

            };
            foreach (var item in Bloglar)
            {
                context.Bloglar.Add(item); //bloglari ekliyoruz
            }
            context.SaveChanges(); //kaydediyoruz
            base.Seed(context);


        }

    }
}