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

namespace MatheWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //DataContext ctx
        MatheModell m = new MatheModell();
        public MainWindow()
        {
            InitializeComponent();
            m.Eingabe = "0";
            m.GenerateRandomNumbers();
            
            this.DataContext = m;

            //DataContext --- z1, z2, eingabe, richtigFalsch,   GesamtRichtig / GesamtFalsch --- 10 von 15 Fragen richtig
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ctx.GenerateRandomNumbers();
            //ctx.NewQuestion();

            m.CheckAnswer();

            m.GenerateRandomNumbers();
        }

        private void NeuesSpielStarten(object sender, RoutedEventArgs e)
        {
            m.ResetGame();
            //Check GesamtRichtig --> 0
        }

     
    }
}
