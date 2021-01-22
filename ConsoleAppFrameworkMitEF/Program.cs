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
            //Insert
            //  ctx.Produkte.Add(p);
            //  ctx.SaveChanges();// "c:\users\johann.grabner\ProduktContext.mdf"

            //Serverexplorer - DAtenverbindungen -
            //Verbindung hinzufügen - SQL Server Datenbnakdatei
            //Löschen, Suchen und ändern
            //11:15 Uhr -- EF & CRUD

            //alle Datensätze auslesen

            //select
            foreach (Produkt produkt in ctx.Produkte)
            {
                Console.WriteLine($"Bez: {produkt.Bezeichnung} Kat {produkt.Kategorie}");
            }

            //Filtern von Daten
            //select ... WHERE Bezeichnung='Kugelschreiber'
            IQueryable<Produkt> ergebnisV1= 
                ctx.Produkte.Where(pr => pr.Bezeichnung == "Kugelschreiber");

            //Compiler ermittelt Datentyp aus der rechten Zuweisung
            var ergebnisV2 = ctx.Produkte.Where(pr => pr.Bezeichnung == "Kugelschreiber");
            Console.WriteLine("Alle Kugelschreiber");
            foreach (var prod in ergebnisV1)
            {
                Console.WriteLine($"Bez: {prod.Bezeichnung}");
            }

            //select... WHERE ProduktId = 1
            var produktMitPK1 = ctx.Produkte.Find(1);
            if (produktMitPK1 != null)
            {
                Console.WriteLine($"Bez: {produktMitPK1.Bezeichnung}");
            }

            //DML - Update
            //Update Produkte set Bezeichnung='Füllfeder'
            //where ProduktId=2
            //1. Holen der Entity 
            //2. Update der Properties "lokal" - im Program
            //3. SaveChanges

            var productToChange = ctx.Produkte.Find(2);
            productToChange.Bezeichnung = "Füllfeder";
            productToChange.Kategorie = "Schreibgerät";
            ctx.SaveChanges(); //Change-Tracker

            //DML - Delete
            //DELET FROM Produkte where ProduktId=2
            //1. Holen der Entity 
            //2. Remove
            //3. SaveChanges
        }
    }
}
