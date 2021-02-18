using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UrlaubWPF
{
    /// <summary>
    /// Interaction logic for Suchfenster.xaml
    /// </summary>
    public partial class Suchfenster : Window
    {
        public SuchfensterViewModel Suche{ get; set; }
        public Suchfenster()
        {
            InitializeComponent();

            Suche = new SuchfensterViewModel();

            this.DataContext = Suche;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
