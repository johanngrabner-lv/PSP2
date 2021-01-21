using System;
using System.Collections.Generic;
using System.Linq;

namespace Produktverwaltung
{
    class Program
    {
        delegate string D1();
        delegate double D2(double a, double b);
        delegate bool D3(int x, int y, int z);
        public static string Hello()
        {
            return "hallo";
        }
        public static double Add(double z1, double z2)
        {
            return z1 + z2;
        }
        public static bool IsGreater(int a, int b, int c)
        {
            return a > b & c>a;
        }

        public static void PrintHello(string firstname)
        {
            Console.WriteLine("Hello");
        }

        static void Main(string[] args)
        {
            Func<string> m1 = Hello;
            Func<double, double, double> m2 = Add;
            Func<int, int, int, bool> m3 = IsGreater;

            Action<string> m4 = PrintHello;
            m4("Johann");



            Console.WriteLine("Produktverwaltung");

            List<Produkt> meineProdukte = new List<Produkt>();
            meineProdukte.Add(new Produkt() 
            { Bezeichnung = "Füllfeder", Kategorie = "Schreibwaren", Preis=120 });
            meineProdukte.Add(new Produkt()
            { Bezeichnung = "Kugelschreiben", Kategorie = "Schreibwaren", Preis = 7 });
            meineProdukte.Add(new Produkt()
            { Bezeichnung = "Drucker", Kategorie = "IT", Preis = 90 });


            foreach (Produkt produkt in meineProdukte)
            {
                if (produkt.Kategorie=="Schreibwaren")
                {
                    Console.WriteLine(produkt.Bezeichnung);
                }
            }

            IEnumerable<Produkt> schreibwaren= 
                meineProdukte.Where(p => p.Kategorie == "Schreibwaren");

            foreach (Produkt produkt in schreibwaren)
            {
                Console.WriteLine(produkt.Bezeichnung);
            }

            IEnumerable<Produkt> guenstig =
               meineProdukte.Where(p => p.Preis<100).OrderByDescending( p => p.Preis);

            foreach (Produkt produkt1 in guenstig)
            {

            }



        }
    }
}
