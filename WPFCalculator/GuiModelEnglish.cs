using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalculator
{
    //Model für eine View
    class GuiModelEnglish : GuiModel, INotifyPropertyChanged
    {
        public string BegrEnglish { get; set; }
    }
}
