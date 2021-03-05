using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    { //count eleman sayısını veriyor.
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Anıl");

            Console.WriteLine(isimler.Length);
            isimler.Add("Yağız");
            Console.WriteLine(isimler.Length);


            //isimleri yazmak için
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
