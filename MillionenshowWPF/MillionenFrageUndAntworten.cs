using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionenshowWPF
{
    class MillionenFrageUndAntworten
    {
        public string Frage { get; set; }

        public string Antwort1 { get; set; }
        public string Antwort2 { get; set; }
        public string Antwort3 { get; set; }
        public string Antwort4 { get; set; }

        public string Eingabe { get; set; }

        public string KorrekteAntwort { get; set; }

        private string _Ergebnis;

        public string Ergebnis
        {
            get { return _Ergebnis; }
            set { _Ergebnis = value; }
        }


    }
}
