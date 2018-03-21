using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._6
{
    class Temperature
    {
        protected int _cesium;
        protected int _kelvin;

        public string Сesium
        {
            set
            {
                _cesium = int.Parse(value);
            }
            get
            {
                if (_cesium < -273)
                    return "Temperature can't be less than -273 degrees Celsius";
                else
                    return Convert.ToString(_cesium);
            }
        }

        public string Kelvin
        {
            get
            {
                if (_cesium < -273)
                    return "Temperature can't be less than 0 degrees Kelvin";
                else
                {
                    _kelvin = _cesium + 273;
                    return Convert.ToString(_kelvin);
                }
            }
        }
    }
}
