using System;
using System.Collections.Generic;
using System.Text;

namespace Shipping.Busniess
{
    public class Item
    {
        public string Id { get; }
        public string Namn { get; }
        public int Pris { get; }

        public Item(string id, string namn, int pris)
        {
            Id = id;
            Namn = namn;
            Pris = pris;
        }
    }
}
