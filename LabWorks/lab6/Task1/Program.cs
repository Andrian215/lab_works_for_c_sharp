using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість елементів:\t");
            int elCount = int.Parse(Console.ReadLine());

            double[] arr = new double[elCount];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{i}:");
                arr[i] = double.Parse(Console.ReadLine());
            }
            double s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            Console.Write(s / elCount);
            Console.ReadLine();
        }
    }
}
