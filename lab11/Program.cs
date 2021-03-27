using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D vector = new Vector2D();
            Vector2D vector1 = new Vector2D { x = 5, y = 4 };
            Vector2D vector2 = new Vector2D { x = 5, y = 4 };
            Vector2D addition = vector1 + vector2;
            Vector2D subtraction = vector1 - vector2;
            Vector2D scalarproduction = vector1 * vector2;
            vector.Input();
            Console.WriteLine(vector.Print());
            Console.WriteLine(vector.Lenth());
            Console.WriteLine(vector.Normalization());
            vector.Compare();
            Console.WriteLine(addition.Value);
            Console.WriteLine(subtraction.Value);
            Console.WriteLine(scalarproduction.ScalarProduct);
            Console.ReadLine();
        }
       
    }
    
}
