using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        // int, decimal, float, double, bool -> değer tipleri
        //array, class, interface -> referans tipleri
        /* stack ve heap kavramları ; stack değer tiplerini tutar ve bir kerelik değişir veya
         * yapar daha sonra bir daha bakmaz kullanmaz. Fakat heap bir adres tutar ve sürekli o adrese
         * göre hareket eder. Referans tipleriyle çalışır. Bu yüzden ilk örnekte değişmedi ama ikinci 
         * örnekte değişti. */
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=999 

        }
    }
}
