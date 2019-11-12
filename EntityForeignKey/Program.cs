using System;
using System.Collections.Generic;
using EntityYazar;

namespace EntityForeignKey
{
    class Program
    {
        static void Main(string[] args)
        {
            var ct=new KitapDbContext();
            // ------ Yazar Eklme Bölümü 
            // Yazar[] yazar=new Yazar[]{new Yazar{YazarAdi="Tolstoy"},new Yazar{YazarAdi="Dosteyevski"}};
            // ct.AddRange(yazar);
            // ct.SaveChanges();
            //-------- Kitap Ekleme Bölümü ---------
            Kitap kitap=new Kitap();
            kitap.KitapAdi="Bahçe Kapısı";
            Yazar yazar=ct.yazarlar.Find(1);
            yazar.Kitaplar=new List<Kitap>(); // Bu olmaz ise nullReferenceException oluyor. 
            yazar.Kitaplar.Add(kitap);
           
            
            ct.SaveChanges();

        }
    }
}
