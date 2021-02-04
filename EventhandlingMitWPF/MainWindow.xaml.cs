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

namespace EventhandlingMitWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        //Event-Handler
        private void einBegruessungsbutton_Click(object sender, RoutedEventArgs e)
        {
            var eingabe = txtName.Text;
            CalcBegruessung(eingabe);
        }

       

        //Event-Handler
        private void lstGeschlecht_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Produkt p = new Produkt();
            p.Preis = 12;
            p.Bezeichnubg = "Handy";



            var eingabe = txtName.Text;
            try
            {
                /*  <ListBoxItem>
                <StackPanel>
                    <Button>Frau</Button>
                </StackPanel>
                </ListBoxItem>
                */
                var stackPanel = (StackPanel) ((ListBoxItem)lstGeschlecht.SelectedValue).Content;

                var button = (Button) stackPanel.Children[0];

                var inhalt = button.Content;
            }
            catch (Exception)
            {

                ;
            }
            var geschlecht = ((ListBoxItem)lstGeschlecht.SelectedValue).Content.ToString(); 
            CalcBegruessung(eingabe,geschlecht);
        }

        private void CalcBegruessung(string eingabe)
        {
            var begr = "Hello " + eingabe;
            Begruessung.Content = begr;
        }

        private void CalcBegruessung(string eingabe, string geschlecht)
        {
            string begr = "Sehr ";
            switch (geschlecht)
            {
                case "Frau":
                    begr += "geehrte Frau ";
                    break;
                case "Mann":
                    begr += "geehrter Herr ";
                    break;
                default:
                    begr = "Hallo ";
                    break;
            }
            begr += eingabe;
            Begruessung.Content = begr;
        }
    }
}
