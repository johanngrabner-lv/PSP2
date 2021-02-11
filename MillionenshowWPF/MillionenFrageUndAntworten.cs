using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionenshowWPF
{
    class MillionenFrageUndAntworten: INotifyPropertyChanged
    {
        public string Frage { get; set; }

        public string Antwort1 { get; set; }
        public string Antwort2 { get; set; }
        public string Antwort3 { get; set; }
        public string Antwort4 { get; set; }

        // public string Eingabe { get; set; }

        private string _Eingabe;

        public string Eingabe
        {
            get { return _Eingabe; }
            set {
                
                _Eingabe = value; 

                if (PropertyChanged!=null)
                {
                    PropertyChanged(this, 
                        new PropertyChangedEventArgs("Ergebnis"));
                }
            }
        }


        public string KorrekteAntwort { get; set; }

        //propfull
        private string _Ergebnis;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Ergebnis
        {
            get {
                if (Eingabe == KorrekteAntwort)
                    return "Super, richtig beantwortet";
                else
                    return "Leider nicht richtig";
            
            }
            set { _Ergebnis = value; }
        }


    }
}
