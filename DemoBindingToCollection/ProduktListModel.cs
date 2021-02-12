using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBindingToCollection
{
    class ProduktListModel
    {
        //public List<Produkt> MeineProdukte{ get; set; }

        public ObservableCollection<Produkt> MeineProdukte { get; set; }
    }
}
