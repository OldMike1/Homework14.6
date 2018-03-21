using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._6
{
    class Temperature
    {
        protected int _degree;
        protected int _kelvin;

        public int Degree
        {
            set
            {
                _degree = value;
            }
            get
            {
                return _degree;
            }
        }

        public int Kelvin
        {
            get
            {
                return _kelvin = _degree + 273;
            }
        }
    }
}
