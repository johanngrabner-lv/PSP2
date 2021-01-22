using ConsoleAppFrameworkMitEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFrameworkMitEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt p = new Produkt() { Bezeichnung = "Kugelschreiber", Kategorie = "Schreibwaren" };

            ProduktContext ctx = new ProduktContext();
            //  ctx.Produkte.Add(p);
            //  ctx.SaveChanges();// "c:\users\johann.grabner\ProduktContext.mdf"

            //Serverexplorer - DAtenverbindungen -
            //Verbindung hinzufügen - SQL Server Datenbnakdatei
            //Löschen, Suchen und ändern
            //11:15 Uhr -- EF & CRUD

            //alle Datensätze auslesen

            foreach (Produkt produkt in ctx.Produkte)
            {
                Console.WriteLine($"Bez: {produkt.Bezeichnung} Kat {produkt.Kategorie}");
            }

            //Filtern von Daten
            IQueryable<Produkt> ergebnisV1= 
                ctx.Produkte.Where(pr => pr.Bezeichnung == "Kugelschreiber");

            //Compiler ermittelt Datentyp aus der rechten Zuweisung
            var ergebnisV2 = ctx.Produkte.Where(pr => pr.Bezeichnung == "Kugelschreiber");
            Console.WriteLine("Alle Kugelschreiber");
            foreach (var prod in ergebnisV1)
            {
                Console.WriteLine($"Bez: {prod.Bezeichnung}");
            }


        }
    }
}
