﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3=");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3=");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            {
                double p = (AB + BC + AC) / 2;
                double S = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
                Console.WriteLine(S);
                Console.ReadLine();
            }
        }
    }
}
