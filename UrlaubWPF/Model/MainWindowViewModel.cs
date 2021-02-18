using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.ComponentModel;

namespace UrlaubWPF.Model
{
    class MainWindowViewModel: INotifyPropertyChanged
    {
        

        public string AnzahlUrlaubGesamt
        {
            get { return "Anzahl gesamt: " + ObservableUrlaubsCollection.Count();}
           
        }
        

        public string AnzahlUrlaubAction
        {
            get { return "Anzahl Action: " + ObservableUrlaubsCollection
                    .Where(u=>u.Urlaubsart=="Action")
                    .Count(); }
           
        }

        public ObservableCollection<string> Urlaubsarten { get; set; }
       
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

        internal void Filtern()
        {
            ObservableUrlaubsCollectionFiltered = new System.Collections.ObjectModel.ObservableCollection<Urlaub>(
                 ObservableUrlaubsCollection.Where(u => u.Beschreibung.Contains(Suchtext)
                 ));

            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("ObservableUrlaubsCollectionFiltered"));
            }
        }

        private Urlaub _AusgewaehlterUrlaub;

        public Urlaub AusgewaehlterUrlaub
        {
            get { return _AusgewaehlterUrlaub; }
            set { 
                _AusgewaehlterUrlaub = value; 
                if (PropertyChanged !=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AusgewaehlterUrlaub"));
                }
            }
        }

        public Urlaub NeuerUrlaub { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddNewUrlaub()
        {
            Urlaub neu = new Urlaub();
            neu.Beschreibung = NeuerUrlaub.Beschreibung;
            neu.Bild = NeuerUrlaub.Bild;
            neu.Urlaubsart = NeuerUrlaub.Urlaubsart;

            int hoechsteId = ObservableUrlaubsCollection.Max(u => u.UrlaubId);

            neu.UrlaubId = ++hoechsteId;
            ObservableUrlaubsCollection.Add(neu);
            //Zusätzlich auch in DB speichern

            int x = (1 > 2) ? 5 : 7;

            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("AnzahlUrlaubGesamt"));

                if (NeuerUrlaub.Urlaubsart=="Relax")
                PropertyChanged(this, new PropertyChangedEventArgs("AnzahlUrlaubRelax"));

//                (NeuerUrlaub.Urlaubsart == "Relax")? PropertyChanged(this, new PropertyChangedEventArgs("AnzahlUrlaubRelax"));

                if (NeuerUrlaub.Urlaubsart == "Action")
                    PropertyChanged(this, new PropertyChangedEventArgs("AnzahlUrlaubAction"));
            }


        }

        public string  Suchtext{ get; set; }
        public ObservableCollection<Urlaub> ObservableUrlaubsCollectionFiltered
        {
            get;
            set;
        }

    }
}
