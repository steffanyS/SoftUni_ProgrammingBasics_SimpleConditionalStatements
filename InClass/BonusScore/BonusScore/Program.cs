using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            int bonusPoints = 0;

            if(points<=100)
            {
                bonusPoints = 5;
            }

            else if(points>100 && points<=1000)
            {
                bonusPoints = (int)(points * 0.2);
            }
            else 
            {
                bonusPoints = (int)(points * 0.1);
            }

            if(points % 2 == 0)
            {
                bonusPoints += 1;
            }

            if(points % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);
        }
    }
}
