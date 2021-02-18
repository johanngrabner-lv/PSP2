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
using UrlaubWPF.Model;

namespace UrlaubWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public void Demo1()
        {
            int i;
        }
        MainWindowViewModel vm = new MainWindowViewModel();
        public MainWindow()
        {
            //i?
            //Load XAML - creates visual tree
            InitializeComponent();

            this.DataContext = vm;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //   MessageBox.Show("(c) Johann Grabner Campus02","Copyright");
            WindowCopyright myWindow = new WindowCopyright();
            myWindow.ShowDialog(); //Dialog-Modus - Modales
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            //var myVM = (MainWindowViewModel)this.DataContext;
            //myVM.ObservableUrlaubsCollection.Add(myVM.NeuerUrlaub);


            // vm.ObservableUrlaubsCollection.Add(vm.NeuerUrlaub);
            vm.AddNewUrlaub();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Suchfenster suchFenster = new Suchfenster();
            suchFenster.ShowDialog();
            //Text welcher im Suchdialog eingegeben wurde
            var suchText = suchFenster.Suche.Suchtext;
            vm.Suchtext = suchText;

            vm.Filtern();

            
        }
    }
}
