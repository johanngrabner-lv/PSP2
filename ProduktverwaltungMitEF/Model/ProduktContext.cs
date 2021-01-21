using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProduktverwaltungMitEF.Model
{
    //NuGet EntityFrameworkCore
    class ProduktContext: DbContext
    {
        public DbSet<Produkt> MeineProdukte{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            //NuGet Microsoft.EntityFrameworkCore.SqlServer
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Produktverwaltung;Integrated Security=True");
        }
    }
}
