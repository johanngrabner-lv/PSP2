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
    /// Interaction logic for SuchfensterBewertung.xaml
    /// </summary>
    public partial class SuchfensterBewertung : Window
    {
        public SuchfensterBewertung Suche { get; set; }
        public SuchfensterBewertung()
        {
            InitializeComponent();
            Suche = new SuchfensterBewertung();
            this.DataContext = Suche;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
