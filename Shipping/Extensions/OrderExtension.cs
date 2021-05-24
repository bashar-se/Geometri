using System;
using System.Collections.Generic;
using Shipping.Busniess;

namespace Shipping.Extensions
{
    public static class OrderExtension
    {
        public static void Print(this Order order)
        {
            Console.WriteLine("The order will be sent to:");
            Console.WriteLine("Country : " + order.Mottagare.Land);
            Console.WriteLine("Person : " + order.Mottagare.Namn);
            Console.WriteLine("Total sum : " + order.GetTotalPrice());
            Console.WriteLine("***********************************");
            Console.Write(Environment.NewLine);
        }
    }
}