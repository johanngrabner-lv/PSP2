using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace UrlaubWPF.Model
{
    class MainWindowViewModel
    {
        private string _AnzahlUrlaubGesamt;

        public string AnzahlUrlaubGesamt
        {
            get { return _AnzahlUrlaubGesamt; }
            set { _AnzahlUrlaubGesamt = value; }
        }
        private string _AnzahlUrlaubAction;

        public string AnzahlUrlaubAction
        {
            get { return _AnzahlUrlaubAction; }
            set { _AnzahlUrlaubAction = value; }
        }
        private string _AnzahlUrlaubRelax;

        public string AnzahlUrlaubRelax
        {
            get { return _AnzahlUrlaubRelax; }
            set { _AnzahlUrlaubRelax = value; }
        }

        public ObservableCollection<Urlaub>
            ObservableUrlaubsCollection
        { get; set; }

        public Urlaub AusgewaehlterUrlaub { get; set; }

        public MainWindowViewModel()
        {
            ObservableUrlaubsCollection = new ObservableCollection<Urlaub>();

            ObservableUrlaubsCollection.Add(
                new Urlaub()
                {
                    UrlaubId = 1,
                    Beschreibung = "am Meer mit Sonnengarantie"
                ,
                    Urlaubsart = "Relax",
                    Bild = "croatia.jpg"
                });

            ObservableUrlaubsCollection.Add(
            new Urlaub()
            {
                UrlaubId = 2,
                Beschreibung = "Urlaub mit Fun"
            ,
                Urlaubsart = "Action",
                Bild = "CostaRica.jpg"
            });

            AusgewaehlterUrlaub = ObservableUrlaubsCollection[1];
        }



    }
}
