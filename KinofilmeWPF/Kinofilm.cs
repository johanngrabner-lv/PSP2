using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinofilmeWPF
{
    class Kinofilm
    {
        public Kinofilm()
        {
            GenreAuswahl = new List<string>();
            GenreAuswahl.Add("Fantasie");
            GenreAuswahl.Add("Komödie");
            GenreAuswahl.Add("Action");
        }
        public List<string> GenreAuswahl { get; set; }
        public string Titel { get; set; }
        public string Erscheinungsjahr { get; set; }

        public string Genre { get; set; }

        public double  Sterne { get; set; }
    }
}
