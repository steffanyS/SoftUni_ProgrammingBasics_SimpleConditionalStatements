﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            var mark = double.Parse(Console.ReadLine());
            if(mark>=5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
