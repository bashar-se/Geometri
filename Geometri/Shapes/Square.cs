using System;

namespace Geometri.Shapes
{
    public class Square : Shape, IShape
    {
        private int X { get; }

        public Square(int x, int y)
        {
            if (x != y || x <= 0 || y <= 0)
                throw new Exception("Wrong square dimensions");

            X = x;
        }
        public double GetArea()
        {
            return X * X;
        }

        public int GetPerimeter()
        {
            return X * 4;
        }

        public override void Print()
        {
            Console.WriteLine("************************");
            Console.WriteLine("The shape is a Square");
            Console.WriteLine($"Area = {GetArea()}");
            Console.WriteLine($"Perimeter = {GetPerimeter()}");
            Console.WriteLine("************************");
        }
    }
}