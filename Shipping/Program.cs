///
/// En order kan skickas till Sverige eller Australien
/// Skriv ut i consolen till vilket land, adress, och person som ordern skickas till och totalsummman 
/// Där ingår priset för varorna plus + fraktkostnad
/// Skickas varorna till Sverige ingår 10% rabatt på fraktkostnaden (rabbatten är inte dragen för de ordrar som jag skapat)
/// Var kreativ och visa att du testat din lösning noga
/// Tänk på att nya länder dit man vill frakta sina varor kan komma att läggas till


using Shipping.Busniess;
using Shipping.Extensions;
using System;

namespace Shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Skapa order - Sweden
            var order = new Order
            {
                Mottagare = new Address
                {
                    Namn = "Nils Nilsson",
                    Land = "Sverige",
                    FraktKostnad = 2000
                },

            };

            order.LineItems.Add(new Item("DALAHÄST", "Dalahäst", 100), 1);
            order.LineItems.Add(new Item("ÄLG", "Älg", 100), 1);
            #endregion

            #region Skapa order - Australia
            var order2 = new Order
            {
                Mottagare = new Address
                {
                    Namn = "John Smith",
                    Land = "Australien",
                    FraktKostnad = 2000
                },

            };

            order2.LineItems.Add(new Item("DALAHÄST", "Dalahäst", 100), 1);
            order2.LineItems.Add(new Item("ÄLG", "Älg", 100), 1);

            #endregion

            order.Print();
            order2.Print();

            Console.ReadLine();
        }
    }
}
