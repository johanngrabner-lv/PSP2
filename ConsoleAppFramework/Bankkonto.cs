using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{
    class Bankkonto
    {
        public string Kontoinhaber { get; set; }

        private double _Kontostand;

        private bool _PrivatOderBusiness;

        public bool PrivatOderBusiness
        {
            get { return _PrivatOderBusiness; }
            set { _PrivatOderBusiness = value; }
        }

       //es geht weiter um 09:15 Uhr mit Events 

        public double Kontostand
        {
            get { return _Kontostand; }
            set {
                _Kontostand = value;
                if (_Kontostand>1000 & OnUeber1000!=null)
                {

                }
                
            }
        }


    }
}
