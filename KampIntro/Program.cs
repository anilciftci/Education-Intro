using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            // kategori etiketi -> değer tutucu , alias  
            string kategoriEtiketi = "Kategori";
            bool girmismi = true;

            Console.WriteLine(kategoriEtiketi);

            if (girmismi==true)
            {
                Console.WriteLine("Aferin");
            }
            else
            {
                Console.WriteLine("Başaramadık abi");
            }


        }
    }
}
