using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBindingToCollection
{
    class ProduktListModel
    {
        //public List<Produkt> MeineProdukte{ get; set; }
        
        //Implements 
        public ObservableCollection<Produkt> 
            MeineProdukte { get; set; }

        public ProduktListModel()
        {
            MeineProdukte = new ObservableCollection<Produkt>();
        }

        public Produkt AusgewaehltesProdukt { get; set; }

        internal void FillSamples()
        {
            MeineProdukte.Add(
                new Produkt() { ProduktId = 1, Preis = 12, 
                Bezeichnung = "Kugelschreiber", Abbildung = "Kugelschreiber.jpg" 
                });

            MeineProdukte.Add(
               new Produkt()
               {
                   ProduktId = 6,
                   Preis = 99,
                   Bezeichnung = "Handy",
                   Abbildung = "Motorola.jpg"
               });
        }
    }
}
