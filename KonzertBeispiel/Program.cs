using System;

namespace KonzertBeispiel
{

    //Event-Subscriber 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            KonzertContainer konzertContainer = new KonzertContainer();

            //Abo - Subscribe

            
            konzertContainer.OnNeuesKonzertHinzugefuegt += KonzertAlarm;

            konzertContainer.OnNeuesKonzertHinzugefuegt += SMS;

            konzertContainer.OnNeuesKonzertHinzugefuegt += Newsletter;
            


            Konzert kEdSheeran = new Konzert() { Bezeichnung = "Ed Sheeran", Veranstaltungsort = "Weiz" };

            konzertContainer.NeuesKonzertEintragen(kEdSheeran);

            konzertContainer.OnNeuesKonzertHinzugefuegt -= Newsletter;


            Konzert ladyGaga = new Konzert() { Bezeichnung = "Lady Gaga", Veranstaltungsort = "Washington" };

            konzertContainer.NeuesKonzertEintragen(ladyGaga);


            ProduktVerwaltung p = new ProduktVerwaltung();
            p.OnNeuesProdukt += NewProduktEventHandler;
            p.NeuesProduktHinzufuegen(new Produkt() { Bezeichnung = "Hose blau" });

            //bis 13:50 Beispiel
            //danach Pause bis 14:15 --- 
            //ab 14:15 Auflösung
        }


        //Event-Handler, Callback-Methode
        public static void KonzertAlarm(string konzertBezeichnung)
        {
            Console.WriteLine("Es wurde ein neues Konzert hinzugefügt " + konzertBezeichnung);     
        }

        //Event-Handler, Callback-Methode
        public static void SMS(string konzertBezeichnung)
        {
            Console.WriteLine("Es wurde ein neues Konzert hinzugefügt " + konzertBezeichnung);
        }
        //Event-Handler, Callback-Methode
        public static void Newsletter(string konzertBezeichnung)
        {
            Console.WriteLine("Es wurde ein neues Konzert hinzugefügt " + konzertBezeichnung);
        }


    }
}
