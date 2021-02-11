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

namespace LayoutcotainerSample
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new DemoModel();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            ListBoxItem listBoxItem = (ListBoxItem)listbox.SelectedValue;
            string farbe = listBoxItem.Content.ToString();

            Color color = (Color)ColorConverter.ConvertFromString(farbe);

            SolidColorBrush myBrush = new SolidColorBrush(color);

            myMenu.Background = myBrush;
        }
    }
}
