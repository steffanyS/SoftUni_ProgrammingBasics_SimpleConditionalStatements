using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = Console.ReadLine();

            if (shape == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var squareArea = a * a;
                Console.WriteLine(Math.Round(squareArea, 3));
            }
            else if (shape == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var rectangleArea = a * b;
                Console.WriteLine(Math.Round(rectangleArea, 3));
            }
            else if (shape == "circle")
            {
                var b = double.Parse(Console.ReadLine());
                var circleArea = Math.PI * b * b;
                Console.WriteLine(Math.Round(circleArea, 3));
            }
            else if(shape== "triangle")
            {
                var a =double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var triangleArea = (a * h) / 2;
                Console.WriteLine(Math.Round(triangleArea, 3));
            }

        }
    }
}
