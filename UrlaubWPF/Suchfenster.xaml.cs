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
        public Suchfenster()
        {
            InitializeComponent();

            this.DataContext = new SuchfensterViewModel();
        }
    }
}
