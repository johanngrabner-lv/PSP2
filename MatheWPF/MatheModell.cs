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
            get {
                int z;
                bool erfolgreich = int.TryParse(Eingabe, out z);
                if (erfolgreich && z == ZZ1 + ZZ2)
                {
                    return "Super richtig";
                }
                else
                {
                    return "Leider falsch";
                }
            
            
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

        public void CheckAnswer()
        {
            //0. Aufgabe vertraut machen mit Sourcecode
            //1. Aufgabe - Operator soll "zufällig werden"  entweder + or - 
            //Property "Operator" --> Random
            //2. Aufgabe - Statuszeile erweitern Anzahl Additionen: 5, Anzahl Subtraktionen: 2

            if (int.Parse(Eingabe) == ZZ1 + ZZ2)
                GesamtRichtig++;
            else
                GesamtFalsch++;
        }
        public void GenerateRandomNumbers()
        {
            Random r = new Random();

            ZZ1 = r.Next(0, 11);
            ZZ2 = r.Next(0, 11);

        }

        public void ResetGame()
        {
            GesamtRichtig = 0;
            GesamtFalsch = 0;
            GenerateRandomNumbers();
        }

    }
}
