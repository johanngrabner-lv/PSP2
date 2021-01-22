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


        }
    }
}
