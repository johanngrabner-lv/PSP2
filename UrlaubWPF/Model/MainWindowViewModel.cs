using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace UrlaubWPF.Model
{
    class MainWindowViewModel
    {
        private string _AnzahlUrlaubGesamt;

        public string AnzahlUrlaubGesamt
        {
            get { return _AnzahlUrlaubGesamt; }
            set { _AnzahlUrlaubGesamt = value; }
        }
        private string _AnzahlUrlaubAction;

        public string AnzahlUrlaubAction
        {
            get { return _AnzahlUrlaubAction; }
            set { _AnzahlUrlaubAction = value; }
        }
        private string _AnzahlUrlaubRelax;

        public string AnzahlUrlaubRelax
        {
            get { return _AnzahlUrlaubRelax; }
            set { _AnzahlUrlaubRelax = value; }
        }

        public ObservableCollection<Urlaub>
            ObservableUrlaubsCollection
        { get; set; }

        public Urlaub AusgeweahlterUrlaub { get; set; }



    }
}
