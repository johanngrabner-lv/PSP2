using System;

namespace ProduktVerwaltungMitEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            ProduktContainer c1 = new ProduktContainer() { Kategorie = "Mode" };
            ProduktContainer c2 = new ProduktContainer() { Kategorie = "IT" };

            c1.OnNewProduct += OnNewProduct;
            c2.OnNewProduct += OnNewProduct;

            c1.AddProdukt(new Produkt() { Bezeichnung = "Hose", Preis = 70 });
            c2.AddProdukt(new Produkt() { Bezeichnung = "PC", Preis = 950.00 });

        }

        private static void OnNewProduct(object arg1, ProduktverwaltungEventArgs arg2)
        {
            //????
            ProduktContainer container = (ProduktContainer)arg1;
            string ausgabe = $"ContainerKategorie: {container.Kategorie} Bez: {arg2.Bezeichnung}";
            Console.WriteLine(ausgabe);
        }


        //Empfohlene Signatur für EvenHandler
        //Sender
        //Klasse : EventArgs
        public void MyEventHandler(object sender, ProduktverwaltungEventArgs e)
        {

        }
    }
}
