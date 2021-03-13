using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Ad = "Anıl";
            musteri1.Soyad = "Çiftçi";
            musteri1.TcNo = "222222222";


            //Mubil Kurye

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "78941";
            musteri2.SirketAdi = "Mobil Kurye";
            musteri2.VergiNo = "334743135";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            //new gördüğümüz her yer aslında bellekteki bir referans no.

            Musteri muster3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}
