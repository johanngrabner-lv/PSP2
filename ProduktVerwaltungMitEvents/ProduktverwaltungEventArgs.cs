using System;
using System.Collections.Generic;
using System.Text;

namespace ProduktVerwaltungMitEvents
{
    class ProduktverwaltungEventArgs : EventArgs
    {
        public string Bezeichnung { get; set; }
        public double  Preis { get; set; }
    }
}
