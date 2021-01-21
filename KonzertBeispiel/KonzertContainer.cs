using System;
using System.Collections.Generic;
using System.Text;

namespace KonzertBeispiel
{
    //Event-Publisher
    class KonzertContainer
    {
        //spezielles Delegate 
        public event Action<string> OnNeuesKonzertHinzugefuegt;
        public List<Konzert> Konzerte2021{ get; set; }
        public KonzertContainer()
        {
            Konzerte2021 = new List<Konzert>();
            Konzerte2021.Add(new Konzert() { Bezeichnung = "Celine Dion", Veranstaltungsort = "Wien" });
            Konzerte2021.Add(new Konzert() { Bezeichnung = "Madsen", Veranstaltungsort = "Graz" });


        }

      

        public void NeuesKonzertEintragen(Konzert konzert)
        {
            Konzerte2021.Add(konzert);
            //throw an exception, eine Ausnahme auslösen / werfen
            //to fire an event, Event feuern / auslösen
            //loose Coupling
            if (OnNeuesKonzertHinzugefuegt != null)
            {
                OnNeuesKonzertHinzugefuegt(konzert.Bezeichnung);
            }
                
            //Program.KonzertAlarm(konzert.Bezeichnung);
        }
    }
}
