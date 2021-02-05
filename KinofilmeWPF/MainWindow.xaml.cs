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

namespace KinofilmeWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Kinofilm kinofilm = new Kinofilm();

            //Defaultwerte setzen
            kinofilm.Titel = "Bitte Titel eingeben";
            kinofilm.Erscheinungsjahr = "2020 Jahr";
            kinofilm.Genre = kinofilm.GenreAuswahl[0];
            kinofilm.Sterne = 8;
            this.DataContext = kinofilm;
        }
    }
}
