using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{
    public class KontoEventArgs
    {
        //Zusatzinfos über das Event
        public double NeuerKontostand { get; set; }
    }
    //Event-Provide, Event-Publisher
    class Bankkonto
    {
        //sender, eventArgs
        public event Action<object, KontoEventArgs> OnKontostandUeber1000;
        public string Kontoinhaber { get; set; }

        private double _Kontostand;

        private bool PrivatOderBusiness { get; set; }


       //es geht weiter um 09:15 Uhr mit Events 

        public double Kontostand
        {
            get { return _Kontostand; }
            set {
                _Kontostand = value;
                //Null-Check ob es registrierte Eventhandler überhaupt gibt
                if (_Kontostand>1000 & OnKontostandUeber1000!=null)
                {
                    //raise an event
                    //event auslösen
                    OnKontostandUeber1000(
                        this,
                        new KontoEventArgs() { NeuerKontostand = _Kontostand });
                }
                
            }
        }


    }
}
