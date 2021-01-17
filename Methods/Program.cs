using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double Fiyati = 15;
            string Aciklamasi = "Amasya elması ";


            Urun urun1 = new Urun();
            urun1.Adi = " : elma";
            urun1.Fiyati = 15;
            urun1.Aciklamasi = "amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = " : KARPUZ";
            urun2.Fiyati = 30;
            urun2.Aciklamasi = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[]{urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklamasi);
                Console.WriteLine("-----------------------");
                 
            }
            sepetManager Sepetmanager = new sepetManager();
                
            Sepetmanager.Ekle(urun1);
            Sepetmanager.Ekle(urun2);
            
        }
    }
}


