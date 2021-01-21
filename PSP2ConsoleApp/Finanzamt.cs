using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2ConsoleApp
{
    interface IBerechnungsLogik
    {
        double Rechnen(double einkommen, double steuersatz);
    }
    class Variante1 : IBerechnungsLogik
    {
        public double Rechnen(double einkommen, double steuersatz)
        {
            return (einkommen + 100) * steuersatz;
        }
    }
    class Variante2 : IBerechnungsLogik
    {
        public double Rechnen(double einkommen, double steuersatz)
        {
            return (einkommen * steuersatz) + 500;
        }
    }
    class Finanzamt
    {
        public double BerechneEinkommensteuer(BerechnungsLogik logik)
        {
            //Komplexe Logik 
            double ergebnis = logik();
            return ergebnis ;
        }

        public double BerechneEinkommensteuer(IBerechnungsLogik logik, double einkommen)
        {
            //Komplexe Logik 
            double ergebnis = logik.Rechnen(einkommen, 30);
            return ergebnis;
        }
    }
}
