using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MillionenshowWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MillionenFrageUndAntworten frageUndAntworten = new MillionenFrageUndAntworten();            
            frageUndAntworten.Frage = "Hauptstadt von Österreich";
            frageUndAntworten.Antwort1 = "Graz";
            frageUndAntworten.Antwort2 = "Wien";
            frageUndAntworten.Antwort3 = "New York";
            frageUndAntworten.Antwort4 = "Dornbirn";

            frageUndAntworten.KorrekteAntwort = "Wien";


            this.DataContext = frageUndAntworten;

        }
    }
}
