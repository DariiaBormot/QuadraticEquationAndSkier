using QuadraticEquation;
using System;
using SkierExercise;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ////to solve quadratic equation uncomment lines below

            //Console.Write("Enter First Coefficient: ");
            //var firstValue = Parcer.ParseToDouble();

            //Console.Write("Enter Second Coefficient: ");
            //var secondValue = Parcer.ParseToDouble();

            //Console.Write("Enter Third Coefficient: ");
            //var thirdValue = Parcer.ParseToDouble();

            //var quadraticEquationService = new QuadraticEquationService();
            //quadraticEquationService.GetRoots(firstValue, secondValue, thirdValue);

            //Console.ReadKey();


            ////Skier exercise

            Console.WriteLine("Enter the initial distance in km: ");
            double X = Parcer.ParseToDouble();

            Console.WriteLine("Enter the percentage increment in distance:");
            double Y = Parcer.ParseToDouble();

            Console.WriteLine("Enter the total distance in km: ");
            double Z = Parcer.ParseToDouble();

            var skiDaysTraker = new DaysTraker();

            var result = skiDaysTraker.GetFinalDay(X, Y, Z);

            Console.ReadKey();
        }

    }
}
