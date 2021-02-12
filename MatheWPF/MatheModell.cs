using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheWPF
{
    class MatheModell: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MatheModell()
        {
            Eingabe = "0";
        }
        private int _GesamtRichtig;
        public int GesamtRichtig
        {
            get { return _GesamtRichtig; }
            set
            {
                _GesamtRichtig = value;
                RaisePropertyChanged("GesamtRichtig");
              
            }

        }

        private int _GesamtFalsch;
        public int GesamtFalsch
        {
            get { return _GesamtFalsch; }
            set
            {
                _GesamtFalsch = value;
                RaisePropertyChanged("GesamtFalsch");
            }
        }

        private int _GesamtAddition;
        public int GesamtAddition
        {
            get { return _GesamtAddition; }
            set
            {
                _GesamtAddition = value;
                RaisePropertyChanged("GesamtAddition");
            }
        }

        private int _GesamtSubtraktion;
        public int GesamtSubtraktion
        {
            get { return _GesamtSubtraktion; }
            set
            {
                _GesamtSubtraktion = value;
                RaisePropertyChanged("GesamtSubtraktion");
            }
        }
        private int _ZZ1;
        public int ZZ1
        {
            get { return _ZZ1; }
            set {             
                _ZZ1 = value;
                RaisePropertyChanged("ZZ1");
                RaisePropertyChanged("Ergebnis");
            }
        }
        private int _ZZ2;
        public int ZZ2
        {
            get { return _ZZ2; }
            set
            {
                _ZZ2 = value;
                RaisePropertyChanged("ZZ2");
                RaisePropertyChanged("Ergebnis");
            }
        }

        private string _Ergebnis;
        public string Ergebnis
        {
            get
            {
                var ergebnis = (CheckAnswer()) ? "super richtig" : "leider falsch";
                return ergebnis;
            }
            set
            {
                _Ergebnis = value;
                RaisePropertyChanged("Ergebnis");
            }
        }

        private string _Eingabe;
        public string Eingabe
        {
            get { return _Eingabe; }
            set
            {
                _Eingabe = value;
                RaisePropertyChanged("Eingabe");
                RaisePropertyChanged("Ergebnis");
            }
        }

        private string _Operator;
        public string Operator
        {
            get { return _Operator; }
            set
            {
                _Operator = value;
                RaisePropertyChanged("Operator");
                RaisePropertyChanged("Ergebnis");
            }
        }

        //Helper to raise an Event
        void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private bool _Pressed;

       

        public bool Pressed
        {
            get { return _Pressed; }
            set {
            
                //GenerateRandomNumbers();
                _Pressed = value; 
                //PropertyChanged();
                //15:20 Uhr
            
            }
        }

        public bool CheckAnswer()
        {
            //0. Aufgabe vertraut machen mit Sourcecode
            //1. Aufgabe - Operator soll "zufällig werden"  entweder + or - 
            //Property "Operator" --> Random
            //2. Aufgabe - Statuszeile erweitern Anzahl Additionen: 5, Anzahl Subtraktionen: 2
            //30 Minuten - Programmieren
            //20 Minuten Pause
            //10:00 Uhr Auflösung

            int eingabeInt = 0;
            if (int.TryParse(Eingabe, out eingabeInt))
            {

                if ((Operator == "+" && eingabeInt == ZZ1 + ZZ2) || (Operator == "-" && eingabeInt == ZZ1 - ZZ2))
                {                   
                    return true;
                }
                else
                {                   
                    return false;
                }
            }

            return false;
        }
        public void GenerateRandomNumbers()
        {
            Random r = new Random();

            ZZ1 = r.Next(0, 11);
            ZZ2 = r.Next(0, 11);

        }

        public void GenerateRandomOperator()
        {
            Random r = new Random();

            var operatorNumber = r.Next(0, 2);

            Operator = (operatorNumber == 0) ? "+" : "-";

            if (Operator == "-")
                GesamtSubtraktion++;
            else
                GesamtAddition++;

        }

        public void ResetGame()
        {
            Eingabe = "0";
            GesamtRichtig = 0;
            GesamtFalsch = 0;
            GesamtSubtraktion = 0;
            GesamtAddition = 0;
            GenerateRandomNumbers();
            GenerateRandomOperator();
        }

    }
}
