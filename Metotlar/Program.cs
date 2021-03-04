using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            

            

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            //type safe -- tip güvenli (java,c#)
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }
            Console.WriteLine( "--------------- Metotlar----------------");

            //instance - örnek
            //encapsulation 

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut" , "Diri armut" , 35);
            sepetManager.Ekle2("Maydonoz", "Taze Maydonoz", 5);

        }
    }
}
//Dont repeat yourself -DRY - Clean Code -Best Practice