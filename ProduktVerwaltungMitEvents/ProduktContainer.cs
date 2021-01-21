using System;
using System.Collections.Generic;
using System.Text;

namespace ProduktVerwaltungMitEvents
{
    class ProduktContainer
    {
        public event Action<object, ProduktverwaltungEventArgs> OnNewProduct;
        public string Kategorie { get; set; }
        List<Produkt> produkte = new List<Produkt>();
        public ProduktContainer()
        {
            produkte = new List<Produkt>();
        }
        public void AddProdukt(Produkt p)
        {
            produkte.Add(p);
            //Event auslösen
            if (OnNewProduct!=null)
            {
                OnNewProduct(this,
                    new ProduktverwaltungEventArgs()
                    {
                        Bezeichnung = p.Bezeichnung,
                        Preis = p.Preis
                    });
            }
        }
    }
}
