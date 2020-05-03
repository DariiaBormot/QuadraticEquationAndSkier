using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkierExercise
{
    public class DaysTraker
    {
        public double GetFinalDay(double firstDayDistance, double increasePercentage, double plannedDistance)
        {

            if(IsValidDistance(firstDayDistance, plannedDistance) && IsValidPercentInput(increasePercentage))
            {
                var result = GetDay(firstDayDistance, increasePercentage, plannedDistance);
                return result;
            }
            return 0;
        }

        private double GetDay(double firstDayDistance, double increasePercentage, double plannedDistance)
        {
            double totalDays = 1;
            double totalDistance = firstDayDistance;

            while (totalDistance <= plannedDistance)
            {
                firstDayDistance *= (1 + (increasePercentage / 100));
                totalDistance += firstDayDistance;
                totalDays += 2;
            }

            Console.WriteLine($"Sportsman will overcome {plannedDistance} km distance in {totalDays} days!");

            return totalDays;
        }

        public bool IsValidDistance(double firstDayDistance, double plannedDistance)
        {
            if (firstDayDistance <= 0 || plannedDistance <= 0)
            {
                Console.WriteLine("distance cannot be equal or less than zero");
                return false;
            }
            if (firstDayDistance > plannedDistance)
            {
                Console.WriteLine("initial distance cannot be bigger than total distance");
                return false;
            }
            return true;
        }

        public bool IsValidPercentInput(double increasePercentage)
        {
            if(increasePercentage < 0 )
            {
                Console.WriteLine("percentage increase cannot be negative number");
                return false;
            }
            return true;
        }

    }
}
