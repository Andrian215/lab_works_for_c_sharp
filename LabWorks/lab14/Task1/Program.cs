using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TPrism
    {
        public uint height { get; set; }
        public uint number_of_sides { get; set; }
        public uint length_of_side { get; set; }

        public double Square()
        {
            double square_of_basis;
            double square_of_sides;
            if (number_of_sides == 3)
            {
                square_of_basis = Math.Sqrt(3) / 4 * length_of_side * length_of_side;
            }
            else if (number_of_sides == 4)
            {
                square_of_basis = length_of_side * length_of_side;
            }
            else if (number_of_sides >= 5)
            {
                square_of_basis = (number_of_sides * length_of_side * length_of_side) / (4 * Math.Tan(180 / number_of_sides));
            }
            else
            {
                square_of_basis = 0;
            }

            square_of_sides = number_of_sides * length_of_side * height;
            double full_square = 2 * square_of_basis + square_of_sides;
            return full_square;
        }

        public double volume;
        public double Volume()
        {
            double square_of_basis;
            if (number_of_sides == 3)
            {
                square_of_basis = Math.Sqrt(3) / 4 * length_of_side * length_of_side;
            }
            else if (number_of_sides == 4)
            {
                square_of_basis = length_of_side * length_of_side;
            }
            else if (number_of_sides >= 5)
            {
                square_of_basis = (number_of_sides * length_of_side * length_of_side) / (4 * Math.Tan(180 / number_of_sides));
            }
            else
            {
                square_of_basis = 0;
            }

            double volume = square_of_basis * height;
            return volume;
        }

    }

    class TPrism3 : TPrism
    {
        public new int number_of_sides = 3;

        public new double Square()
        {
            double square_of_basis;
            double square_of_sides;

            square_of_basis = Math.Sqrt(3) / 4 * length_of_side * length_of_side;
            square_of_sides = number_of_sides * length_of_side * height;
            double full_square = 2 * square_of_basis + square_of_sides;
            return full_square;
        }

        public new double Volume()
        {
            double square_of_basis;

            square_of_basis = Math.Sqrt(3) / 4 * length_of_side * length_of_side;
            double volume = square_of_basis * height;
            return volume;
        }
    }

    class TPrism4 : TPrism
    {
        public new int number_of_sides = 4;

        public new double Square()
        {
            double square_of_basis;
            double square_of_sides;

            square_of_basis = length_of_side * length_of_side;
            square_of_sides = number_of_sides * length_of_side * height;
            double full_square = 2 * square_of_basis + square_of_sides;
            return full_square;
        }

        public new double Volume()
        {
            double square_of_basis;

            square_of_basis = length_of_side * length_of_side;
            double volume = square_of_basis * height;
            return volume;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TPrism Prism = new TPrism();
            Console.Write("height of prism(Prism with 3 sides)=");
            uint h1 = uint.Parse(Console.ReadLine());
            Console.Write("length of side(Prism with 3 sides)=");
            uint side1 = uint.Parse(Console.ReadLine());
            TPrism prism1 = new TPrism3 { height = h1, length_of_side = side1 };

            Console.Write("height of prism(Prism with 4 sides)=");
            uint h2 = uint.Parse(Console.ReadLine());
            Console.Write("length of side(Prism with 4 sides)=");
            uint side2 = uint.Parse(Console.ReadLine());
            TPrism prism2 = new TPrism3 { height = h2, length_of_side = side2 };

            Console.Write("m=");
            uint m = uint.Parse(Console.ReadLine());

            int k = 50;
            double volume = 0;
            double h = Prism.height;
            for (int i = 0; i < m; i++)
            {
                TPrism prism = new TPrism3 { volume = k };
                k += 5;
                volume += prism.volume;
            }

            double sum = 0;
            for (int i = 0; i < m; i++)
            {
                TPrism prismm = new TPrism { volume = k / h };
                k += 5;
                sum += prismm.volume;
            }

            Console.ReadLine();
        }
    }
}
