using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFrameworkMitEF.Model
{
    //Code first - POCO
    class Produkt
    {
        //Klasse + ID --> Primarschlüssel
        [Key]
        public int ProduktID { get; set; }
        public string Bezeichnung { get; set; }
        public string Kategorie { get; set; }
    }
}
