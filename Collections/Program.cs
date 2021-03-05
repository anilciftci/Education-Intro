using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTRL K+C toplu yorum satırı, CTRL K+U toplu yorum satırı kapatma
            /* string[] isimler = new string[] { "Ela", "Dilan", "Mesut", "Yagız" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5];
            isimler[4] = "Anıl";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            // stack ve heap örneklerindeki gibi tekrar burda stack ve heap dan dolayı 15. satırda
            heap da "isimler" isimli yeni bi adres açtığı için ikinci seferde yani yeni dizide
            0 1 2 3 numaralı yerler boştur sadece Anıl yazar.
            Ve burada görüldüğü gibi bir diziye sonradan değer atayamadığım için List yapısını kullanıyoruz.
              */

            List<string> isimler2 = new List<string>() { "Ela", "Dilan", "Mesut", "Yagız" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Anıl");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);










        }

    }
}
