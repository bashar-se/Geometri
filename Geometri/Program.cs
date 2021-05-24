///
/// Beräkna arean o omkretsen på en kvadrat, rektangel och parallelltrapets
/// Skriv ut arean, omkretsen och vilken typ av figur det är, skriv ut i consolen
/// Jag har skapat 3 arrayer, arrayen avgör vilken typ figur det är
/// Var kreativ och visa att du testat din lösning noga

using Geometri.Shapes;
using System;
using System.Collections.Generic;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] figur1 = new int[] { 5, 5 };
            int[] figur2 = new int[] { 5, 4, 5, 4 };
            int[] figur3 = new int[] { 5, 5, 4, 4, 3 };

            IList<Shape> shapes = new List<Shape>();
            
            shapes.Add(Shape.CreateShape(figur1));
            shapes.Add(Shape.CreateShape(figur2));
            shapes.Add(Shape.CreateShape(figur3));

            PrintShapesInfo(shapes);

            Console.ReadLine();
        }

        private static void PrintShapesInfo(IList<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Print();
                Console.Write(Environment.NewLine);
            }
        }
    }
}
