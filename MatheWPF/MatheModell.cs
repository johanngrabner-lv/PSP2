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

        private int _ZZ1;
        public int ZZ
        {
            get { return _ZZ1; }
            set {             
                _ZZ1 = value;
                RaisePropertyChanged("ZZ1");
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
            }
        }

        private int _Eregebnis;
        public int Eregebnis
        {
            get { return _Eregebnis; }
            set
            {
                _Eregebnis = value;
                RaisePropertyChanged("Eregebnis");
            }
        }

        private int _Eingabe;
        public int Eingabe
        {
            get { return _Eingabe; }
            set
            {
                _Eingabe = value;
                RaisePropertyChanged("Eingabe");
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

    }
}
