using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            temperature.Сesium = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(temperature.Сesium + " degrees Celsius");
            Console.WriteLine(temperature.Kelvin + " degrees Kelvin");

        }
    }
}
