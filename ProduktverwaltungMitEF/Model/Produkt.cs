using System;
using System.Collections.Generic;
using System.Text;

namespace ProduktverwaltungMitEF
{
    class Produkt
    {
        //Primärschlüssel - Klassenname + Id
        public int ProduktId { get; set; }
        public string Bezeichnung { get; set; }
        public double Preis { get; set; }
    }
}
