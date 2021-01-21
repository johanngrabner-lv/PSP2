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
