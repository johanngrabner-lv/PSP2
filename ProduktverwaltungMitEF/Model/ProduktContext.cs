using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProduktverwaltungMitEF.Model
{
    //NuGet EntityFrameworkCore
    //https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=visual-studio
    class ProduktContext : DbContext
    {
        public DbSet<Produkt> MeineProdukte{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
                Install-Package Microsoft.EntityFrameworkCore.Tools
                Add-Migration InitialCreate
                Update-Database
                Add-Migration AddKategorie
                Update-Database
            */
            //NuGet Microsoft.EntityFrameworkCore.SqlServer
            //c:\user\jgrabner\Produktverwaltung.mdf
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Produktverwaltung;Integrated Security=True");
        }
    }
}
