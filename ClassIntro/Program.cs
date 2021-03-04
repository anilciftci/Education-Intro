using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "İbrahim Yağız Çiftçi";
            kurs1.ProgramlamaDili = "Python";
            kurs1.Izlenme = 100;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Dilan Çiftçi";
            kurs2.ProgramlamaDili = "C++";
            kurs2.Izlenme = 95;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Mesut Çiftçi";
            kurs3.ProgramlamaDili = "Java";
            kurs3.Izlenme = 98;

            Kurs kurs4 = new Kurs();
            kurs4.Egitmen = "Ela Nur Çiftçi";
            kurs4.ProgramlamaDili = "JavaScript";
            kurs4.Izlenme = 99 ;

            Kurs kurs5 = new Kurs();
            kurs5.Egitmen = "Anıl Çiftçi";
            kurs5.ProgramlamaDili = "C#";
            kurs5.Izlenme = 94;

            Kurs[] kurslar = new Kurs[]  {kurs1,kurs2,kurs3,kurs4, kurs5};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen + " : " + kurs.ProgramlamaDili + " " + kurs.Izlenme);
            }
            

        }

        class Kurs
        {
            public string ProgramlamaDili { get; set; }
            public string Egitmen { get; set; }

            public int Izlenme { get; set; }

        }


    }
}
