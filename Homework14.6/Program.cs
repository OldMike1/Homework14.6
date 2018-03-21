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
            temperature.Degree = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(temperature.Degree + " gradus");
            Console.WriteLine(temperature.Kelvin + " kelvins");

        }
    }
}
