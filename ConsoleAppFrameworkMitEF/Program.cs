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
            Produkt p = new Produkt() { Bezeichnung = "Handy", Kategorie = "Telekommunikation" };

            ProduktContext ctx = new ProduktContext();
            ctx.Produkte.Add(p);
            ctx.SaveChanges();// "c:\users\johann.grabner\ProduktContext.mdf"
        }
    }
}
