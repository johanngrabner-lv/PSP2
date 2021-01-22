using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            //Func --> Return Wert, Action --> void
            //Generische Delegates
            //Callbacks, "Logik übergeben" 
            //delegate int MyDelegate(int i, int j)
            //MyDelegate d1 = Add;
            Func<int, int, int> zeigerAufBerechnung;
            zeigerAufBerechnung = Add;
            int ergebnisAdd = zeigerAufBerechnung(10, 20);
            zeigerAufBerechnung = Sub;
            int ergebnisSub = zeigerAufBerechnung(10, 6);
            Func<double, int, bool> compareTwoNumbers = IsAGreaterThanB;

            CalcAndPrint(Add, 10, 20);
            CalcAndPrint(Sub, 10, 20);

            Func<string, int> anzahlZeichen = x => x.Length;

            int anzahlJohann = anzahlZeichen("Johann");

            //Lambda 
            CalcAndPrint((x, y) => x + y, 5, 7);

            CalcAndPrint((x, y) => x - y, 5, 7);

            CalcAndPrint((x, y) => x % y, 5, 7);

            Bankkonto k1 = new Bankkonto() { Kontoinhaber = "Jungwirth" };
            Bankkonto k2 = new Bankkonto() { Kontoinhaber = "Jandl" };

            k1.OnKontostandUeber1000 += K1_OnKontostandUeber1000;
            k2.OnKontostandUeber1000 += K2_OnKontostandUeber1000;

            k1.Kontostand = 700;
            k1.Kontostand = 1500;
            k2.Kontostand = 1700;

            //bis 10 Uhr Pause

        }

        private static void K2_OnKontostandUeber1000(object arg1, KontoEventArgs e)
        {
            Console.WriteLine($"neuer Kontoastnand {e.NeuerKontostand}");
            Console.Beep(5000, 1000);
        }

        private static void K1_OnKontostandUeber1000(object arg1, KontoEventArgs e)
        {
            Console.WriteLine($"neuer Kontoastnand {e.NeuerKontostand}");
            Console.WriteLine("Time for shopping");
        }

        public static bool IsAGreaterThanB(double a, int b)
        {
            return a > b;
        }
        public static void CalcAndPrint(Func<int,int,int> func, int z1, int z2)
        {
            int ergebnis = func(z1, z2);
            Console.WriteLine($"Ergebnis: {ergebnis}");
        }

        public static int Add(int z1, int z2)
        {
            return z1 + z2;
        }
        public static int Sub(int z1, int z2)
        {
            return z1 - z2;
        }
    }
}
