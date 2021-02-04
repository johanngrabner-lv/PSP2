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

namespace WPFCalculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PropInCSharp p = new PropInCSharp();
            p.setZahl(12);
            p.MyNumber = 17;

            // GuiModel m = new GuiModel() { Begruessung = "Willkommen zum Campus02-Calculator" };
            GuiModel m = new GuiModelEnglish() { Begruessung = "Willkommen zum Campus02-Calculator",BegrEnglish="Hello english" };
            
            m.Vorname = "Unbekannt";

            m.z1 = 20;
            m.z2 = 10;

            if (m.ergebnis!="Result: 40")
            {
                //Vorsicht fehler
            }



            //Prozedural
            //btn.Content = m.Begruessung;
            //t1.Text = 7;
            //t2.Text = 9;


            //Schritt ist Datenkontext setzen
            //Datenkontext der View (MainWindow) auf das Model (GuiModel) setzen 
            //Datenkontext - Bindeglied zwischen View und Model, missing gap
            //this - zeiger auf MainWindow
            this.DataContext = m;
            //2. Schritt -- deklaratives Databinding

        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            int z1 = int.Parse(txt1.Text);
            int z2 = int.Parse(txt2.Text);

            int index = lstAdditionSub.SelectedIndex;

            int erg = (index==0) ? z1+z2: z1 - z2;

            if (index == 0)
                erg = z1 + z2;
            else
                erg = z1 -z2;

            lblErgebnis.Content = $"Ergebnis {erg} ";


        }
    }
}
