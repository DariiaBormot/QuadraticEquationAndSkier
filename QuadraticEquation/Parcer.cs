using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    public class Parcer
    {
        public static double ParseToDouble()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter a valid numeric value");
            }
            return number;
        }
    }
}
