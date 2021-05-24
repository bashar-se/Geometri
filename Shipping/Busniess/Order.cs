using System;
using System.Collections.Generic;
using System.Text;

namespace Shipping.Busniess
{
    public class Order
    {
        public Dictionary<Item, int> LineItems { get; } = new Dictionary<Item, int>();
        public Address Mottagare { get; set; }

        public double GetTotalPrice()
        {
            double sum = 0;
            foreach (var item in LineItems)
            {
                var key = item.Key;
                var value = item.Value;
                sum += key.Pris * value;
            }
            return sum + GetShippingCost();
        }

        private double GetShippingCost()
        {
            return Mottagare.FraktKostnad - GetDiscount(Mottagare.FraktKostnad);
        }

        private double GetDiscount(double shippingCost)
        {
            if (Discount.Countries.ContainsKey(Mottagare.Land))
            {
                return shippingCost * Discount.Countries[Mottagare.Land] / 100;
            }
            return 0;
        }
    }

    public class Address
    {
        public string Namn { get; set; }
        public string Land { get; set; }
        public int FraktKostnad { get; set; }
    }
}
