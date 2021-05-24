using System;

namespace Geometri.Shapes
{
    public class Trapezoid : Shape, IShape
    {
        private int Length { get; }
        private int Width { get; }
        private int Height { get; }

        public Trapezoid(int x1, int x2, int y1, int y2, int h)
        {
            if (x1 != x2 || 
                y1 != y2 || 
                IsNegativeOrZeroDimension(x1, y1, x2, y2))
                throw new Exception("Wrong trapezoid dimensions");

            Length = x1;
            Width = y1;
            Height = h;
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
            var area = (Width + Length) * Height / Convert.ToDouble(2);
            return  area;
        }

        public int GetPerimeter()
        {
            return (Length * 2) + (Width * 2);
        }

        public override void Print()
        {
            Console.WriteLine("************************");
            Console.WriteLine("The shape is a Trapezoid");
            Console.WriteLine($"Area = {GetArea()}");
            Console.WriteLine($"Perimeter = {GetPerimeter()}");
            Console.WriteLine("************************");
        }
    }
}