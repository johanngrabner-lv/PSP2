using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFrameworkMitEF.Model
{
    class Produkt
    {
        //Klasse + ID --> Primarschlüssel
        public int ProduktID { get; set; }
        public string Bezeichnung { get; set; }
        public string Kategorie { get; set; }
    }
}
