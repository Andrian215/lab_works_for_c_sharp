﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            {
                if (a >= 1 & a <= 2 || a > 3 & a < 7)
                {
                    Console.WriteLine("а належить цьому iнтервалу");
                }
                else
                {
                    Console.WriteLine("а не належить цьому iнтервалу");
                }
            }

            {
                if (b >= 1 & b <= 2 || b > 3 & b < 7)
                {
                    Console.WriteLine("b належить цьому iнтервалу");
                }
                else
                {
                    Console.WriteLine("b не належить цьому iнтервалу");
                }
            }

            Console.ReadLine();

        }
    }
}
