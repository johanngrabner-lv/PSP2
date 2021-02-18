﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;

namespace UrlaubWPF.Model
{
    class MainWindowViewModel
    {
        private string _AnzahlUrlaubGesamt;

        public string AnzahlUrlaubGesamt
        {
            get { return "Anzahl gesamt: " + ObservableUrlaubsCollection.Count();}
           
        }
        private string _AnzahlUrlaubAction;

        public string AnzahlUrlaubAction
        {
            get { return "Anzahl Action: " + ObservableUrlaubsCollection
                    .Where(u=>u.Urlaubsart=="Action")
                    .Count(); }
           
        }

        public ObservableCollection<string> Urlaubsarten { get; set; }
        private string _AnzahlUrlaubRelax;

        public string AnzahlUrlaubRelax
        {
            get {
                return "Anzahl Relax: " + ObservableUrlaubsCollection
                  .Where(u => u.Urlaubsart == "Relax")
                  .Count();
            }
           
        }

        public ObservableCollection<Urlaub>
            ObservableUrlaubsCollection
        { get; set; }

     

        public MainWindowViewModel()
        {
            ObservableUrlaubsCollection = new ObservableCollection<Urlaub>();

            ObservableUrlaubsCollection.Add(
                new Urlaub()
                {
                    UrlaubId = 1,
                    Beschreibung = "am Meer mit Sonnengarantie",
                    Urlaubsart = "Relax",
                    Bild = "croatia.jpg"
                });

            ObservableUrlaubsCollection.Add(
            new Urlaub()
            {
                UrlaubId = 2,
                Beschreibung = "Urlaub mit Fun",
                Urlaubsart = "Action",
                Bild = "CostaRica.jpg"
            });

            ObservableUrlaubsCollection.Add(
        new Urlaub()
        {
            UrlaubId = 3,
            Beschreibung = "biken in den Bergen",
            Urlaubsart = "Action",
            Bild = "Salzburg.jpg"
        });

            AusgewaehlterUrlaub = ObservableUrlaubsCollection[1];

            Urlaubsarten = new ObservableCollection<string>();
            Urlaubsarten.Add("Relax");
            Urlaubsarten.Add("Action");

            NeuerUrlaub = new Urlaub();
        }

        public Urlaub AusgewaehlterUrlaub { get; set; }
        public Urlaub NeuerUrlaub { get; set; }

    }
}
