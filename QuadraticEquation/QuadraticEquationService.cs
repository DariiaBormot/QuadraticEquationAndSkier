using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    public class QuadraticEquationService
    {

        public double[] GetRoots(double A, double B, double C)
        {
            double[] Result = new double[2];

            double discriminant = Math.Pow(B, 2) - 4 * A * C;

            if (!IsNotZero(A))
            {
                throw new InvalidOperationException("First coefficient cannot be zero value");
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("There are no roots");
                return Result;

            }
            else if (discriminant == 0)
            {
                double X1 = (-B + Math.Sqrt(discriminant)) / (2 * A);

                Console.WriteLine($"There is one root : {X1}");

                Result[0] = X1;
                return Result;
            }
            else
            {
                double X1 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                double X2 = (-B + Math.Sqrt(discriminant)) / (2 * A);

                Result[0] = X1;
                Result[1] = X2;

                Console.WriteLine($"There are two roots \nX1: {X1} \nX1: {X2}");
                return Result;

            }
  
        }

        public bool IsNotZero(double value)
        {
            if (value == 0)
                return false;
            else
                return true;
        }

    }

}
