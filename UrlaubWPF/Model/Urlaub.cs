﻿using System;
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

        //Bewertung von 0 Punkten bis 10 Punkte über einen Slider
        // public int Bewertung { get; set; }
        private int _Bewertung;

        public int Bewertung
        {
            get { return _Bewertung; }
            set { 
                _Bewertung = value; 
                if (PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Bewertung"));
                }
            }
        }


        //Kontrollkästchen in der GUI
        public bool Vorgemerkt { get; set; }

        public string Kontinent { get; set; }
    }

    //Server Explorer - Data Connections - Add Connection 
    //Microsoft SQL Server Database File (SqlClient)
    //Browse - c:\Users\jgrabner\.....UrlaubV1.mdf
    //Aufgabe 18.02.2021
    //GUI Erweitern 
    //-- Bewertung über Slider Value={Binding Bewertung
    //Vorgemerkt über ToogleButton, Kontrollkästchen -- IsChecked={Binding Vorgemerkt
    //Löschen eines Urlaubs
    //2. Suchdialog - Suchen nach "Vorgemerkt", Bewertung zwischen 5 und 7
    //bis 15:00 Uhr - Pause bis 15:15 --- >Projektbesprechung bzw. Auflösung
}
