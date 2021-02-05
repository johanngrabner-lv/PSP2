using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendWPF
{
    class Freitag: INotifyPropertyChanged
    {

        public string Farbe { get; set; }
        public List<string> Sprueche { get; set; }

        public List<string> Bilder { get; set; }


        private string _BildDesTages;

        public string BildDesTages
        {
            get {
                Random r = new Random();
                int bildNumber = r.Next(0, Bilder.Count);
                return Bilder[bildNumber];
            }
            set { _BildDesTages = value; }
        }


        private string _Spruch;

        public string Spruch
        {
            get
            {

                Random r = new Random();
                int spruchNumber = r.Next(0, Sprueche.Count);
                return Sprueche[spruchNumber];
            }
            set { _Spruch = value; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void Refresh()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("BildDesTages"));
                PropertyChanged(this, new PropertyChangedEventArgs("Spruch"));

            }
        }

    

    }
}
