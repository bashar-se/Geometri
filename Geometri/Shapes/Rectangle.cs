using System;

namespace Geometri.Shapes
{
    public class Rectangle : Shape, IShape
    {
        private int Length { get; }

        private int Width { get; }

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            if (x1 != x2 ||
                y1 != y2 ||
                IsNegativeOrZeroDimension(x1, y1, x2, y2))
            {
                throw new Exception("Wrong rectangle dimensions");
            }

            Length = x1;
            Width = y1;
        }

        private static bool IsNegativeOrZeroDimension(params int[] dimensions)
        {
            foreach (var dimension in dimensions)
            {
                if (dimension <= 0)
                    return true;
            }

            return false;
        }

        public double GetArea()
        {
            return Length * Width;
        }

        public int GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public override void Print()
        {
            Console.WriteLine("************************");
            Console.WriteLine("The shape is a Rectangle");
            Console.WriteLine($"Area = {GetArea()}");
            Console.WriteLine($"Perimeter = {GetPerimeter()}");
            Console.WriteLine("************************");
        }
    }
}