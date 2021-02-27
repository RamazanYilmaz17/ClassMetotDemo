using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.musteriAd = "Ali";
            m1.musteriSoyad = "Yılmaz";
            m1.musteriYas = 20;

            Musteri m2 = new Musteri();
            m2.musteriAd = "Ahmet";
            m2.musteriSoyad = "Bayram";
            m2.musteriYas = 27;

            Musteri m3 = new Musteri();
            m3.musteriAd = "Oğuz";
            m3.musteriSoyad = "Sert";
            m3.musteriYas = 30;

            Musteri[] musteriler = new Musteri[] { m1, m2, m3 };
            Console.WriteLine("------------------Müşterilerimiz----------------");
            foreach (Musteri m in musteriler)
            {
                Console.WriteLine(m.musteriAd + " " + m.musteriSoyad + " " + m.musteriYas);
            }

            Console.WriteLine("-------------Müşteri Ekleniyor-------------\n");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(m1);

            Console.WriteLine("-------------Müşteriler Listeleniyor-----------\n");
            musteriManager.Listeleme(m1);
            musteriManager.Listeleme(m2);
            musteriManager.Listeleme(m3);

            Console.WriteLine("-------------Müşteri Siliniyor-----------\n");
            musteriManager.Silme(m3);
        }
    }
}
