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

namespace WeekendWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Freitag freitag = new Freitag();
        public MainWindow()
        {
            InitializeComponent();
            freitag.BildDesTages = "Winter.jpg";
            freitag.Sprueche = new List<string>();
            freitag.Sprueche.Add("Bald ist Wochenende");
            freitag.Sprueche.Add("Fasst geschafft");
            freitag.Sprueche.Add("Frühling");

            freitag.Bilder = new List<string>();
            freitag.Bilder.Add("Winter.jpg");
            freitag.Bilder.Add("Fruehling.jpg");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblBegruessung.Content = freitag.Spruch;
            //Bild.Source = new ImageSource()
        }
    }
}
