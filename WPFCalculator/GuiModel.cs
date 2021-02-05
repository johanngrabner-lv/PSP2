using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalculator
{
    //Model für eine View
    class GuiModel: INotifyPropertyChanged
    {
        public string Begruessung { get; set; }

        //public string Vorname { get; set; }
        private string _Vorname;

        public string Vorname
        {
            get { return _Vorname; }
            set { 

                _Vorname = value; 
                if (PropertyChanged != null)
                {
                    //GUI über Property-Änderungen informieren
                    //damit GUI ein Update durchführen kann
                    PropertyChanged(this, new PropertyChangedEventArgs("Vorname"));
                    PropertyChanged(this, new PropertyChangedEventArgs("HelloMessage"));
                }
            }
        }




        public string HelloMessage
        {
            get { return "Hello " + Vorname; }
            set { }
        }

        private int _Z1;

        public int z1
        {
            get { return _Z1; }
            set
            {
                _Z1 = value;
                if (PropertyChanged != null)
                {
                    //GUI über Property-Änderungen informieren
                    //damit GUI ein Update durchführen kann
                    PropertyChanged(this, new PropertyChangedEventArgs("ergebnis"));

                }
            }
        }

        //'+'/'*
        public string MathOperator { get; set; }


        private int _Z2;

        public int z2
        {
            get { return _Z2; }
            set { _Z2 = value;
                if (PropertyChanged != null)
                {
                    //GUI über Property-Änderungen informieren
                    //damit GUI ein Update durchführen kann
                    PropertyChanged(this, new PropertyChangedEventArgs("ergebnis"));

                }
            }
        }

        private string _Eregebnis;

        public string ergebnis
        {
            get { return "Ergebnis " + ( _Z1 + _Z2); }
            set { _Eregebnis = value; }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
