using System;

namespace Geometri.Shapes
{
    public abstract class Shape
    {
        public static Shape CreateShape(params int[] shapeParameters)
        {
            switch (shapeParameters.Length)
            {
                case 2:
                    return new Square(
                                    shapeParameters[0], 
                                    shapeParameters[1]);
                case 4:
                    return new Rectangle(
                                        shapeParameters[0], 
                                        shapeParameters[1], 
                                        shapeParameters[2], 
                                        shapeParameters[3]);
                case 5:
                    return new Trapezoid(
                                        shapeParameters[0],
                                        shapeParameters[1],
                                        shapeParameters[2],
                                        shapeParameters[3],
                                        shapeParameters[4]);
                default:
                    throw new Exception("Unknown shape!");
            }
        }

        public virtual void Print()
        {
            Console.WriteLine("Unknown shape!");
        }
    }
}