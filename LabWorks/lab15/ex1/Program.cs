using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     class Program
    {
        static void Main(string[] args)
        {
            ConvexQuadrangle quad = new ConvexQuadrangle { a=4,b=7,c=6,d=10 };

            
            quad.AssignmentSides();
            Console.WriteLine(quad.Perimetr());
            Console.WriteLine(quad.Square());
            quad.TypeOfQuadrangle();
            Console.ReadLine();
        }
    }
}
