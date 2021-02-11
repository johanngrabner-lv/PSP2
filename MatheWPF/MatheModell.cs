using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheWPF
{
    class MatheModell
    {

        private bool _Pressed;

        public bool Pressed
        {
            get { return _Pressed; }
            set {
            
                //GenerateRandomNumbers();
                _Pressed = value; 
            
            }
        }

    }
}
