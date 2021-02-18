using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UrlaubWPF.Model
{
    class Urlaub: INotifyPropertyChanged
    {
        public int UrlaubId { get; set; }
        private string _Urlaubsart;

        public string Urlaubsart
        {
            get { return _Urlaubsart; }
            set { 
                _Urlaubsart = value; 
                if (PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Urlaubsart"));
                }
            }
        }

        public string Beschreibung { get; set; }
        public string Bild { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
