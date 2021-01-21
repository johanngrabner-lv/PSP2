using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2ConsoleApp
{
    class Program
    {
        //neuer Datentyp, ähnlich wie class Person{.....
        //Person p1; Person p2;
        //ZeigerAufMethode z1;
        //ZeigerAufMethode z2;
        delegate int ZeigerAufMethode(int z1, int z2);
        delegate void ZeigerAufMethodeV2(string s);
        //delegate double ZeigerAufMethodeV3(Person p);
        delegate void SayHello();


        static void Main(string[] args)
        {
            Math m1 = new Math();
           

            //delegate - Variable welche Methoden-Adressen speichern kann
            int i = 12;
            //Datentyp variable = m1.Add; 
            int ergebnis1 = m1.Add(12, 5);
            ZeigerAufMethode z1 = m1.Add; //m1.Add() -- 
            int erbebnis2 = z1(12, 5);
            z1 = m1.Subtract;
            int ergebnis3 = z1(10, 2);

            Finanzamt f1 = new Finanzamt();
            f1.BerechneEinkommensteuer(new Variante1(), 20);
            f1.BerechneEinkommensteuer(new Variante2(), 20);

            f1.BerechneEinkommensteuer(V1,10);
            f1.BerechneEinkommensteuer(V2, 10);

            SayHello(french, "Male"); // delegate
            SayHello(new Frechn(), "Female"); // Interface 
            SayHello(italien, "Female");
            SayHello(new Italien(),"Female");
            SayHello(spanish,"Male");
            SayHello(german,"Female");

        }

        //Auflösung 10:50
        public static void SayHello(..... logik, string geschlecht) //Inferface / Delegate
        {
            string ergebnis = logik();
            Console.WriteLine(ergebnis); "Hola, Ciau, Hallo";
        }

        public static double  V1(double e, double s)
        {
            return (e * 0.30) + s;
        }
        public static double V2(double e, double s)
        {
            return (e + 10) * s;
        }

    }
}
