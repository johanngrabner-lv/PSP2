using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFrameworkMitEF.Model
{
    //NuGet EntityFramework
    class ProduktContext: DbContext
    {
        public DbSet<Produkt> Produkte{ get; set; }
    }
}
