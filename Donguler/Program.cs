using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayfa sonu - footer
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Programlama için temel kurs";
            string kurs3 = "Java";


            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı",
            "Programlama için temel kurs",
            "Java",
            "Python"
            ,"C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu");

        }
    }
}
