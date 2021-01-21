using ProduktverwaltungMitEF.Model;
using System;

namespace ProduktverwaltungMitEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Produkt p1 = new Produkt() { Bezeichnung = "Tastatur", Preis = 50, Kategorie="IT" };

            ProduktContext ctx = new ProduktContext();

            ctx.MeineProdukte.Add(p1);

            ctx.SaveChanges(); //Speichert das neue Produkt in der DB

        }
    }
}
