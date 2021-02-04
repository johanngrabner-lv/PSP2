using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalculator
{
    class PropInCSharp
    {

        private int _Zahl;

        public void setZahl(int value)
        {
            _Zahl = value;
        }

        private int _ANumber;

        public int MyNumber
        {
            get { return _ANumber; }
            set { _ANumber = value; }
        }

    }
}
