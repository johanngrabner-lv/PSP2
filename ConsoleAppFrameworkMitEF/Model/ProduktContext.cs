using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFrameworkMitEF.Model
{
    //1. Console-App .NET Framework
    //2. Ordner / Folder - Mode
    //3. Klasse Produkt ---prop ProduktId, Bezeichnung, Kategorie
    //4. Klasse ProduktContext : DbContext
    //NuGet EntityFramework 
    class ProduktContext : DbContext
    {
        public DbSet<Produkt> Produkte{ get; set; }
    }
}
