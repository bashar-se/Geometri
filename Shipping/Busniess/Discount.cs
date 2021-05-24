using System.Collections.Generic;

namespace Shipping.Busniess
{
    public static class Discount
    {
        public static Dictionary<string, int> Countries { get; } = new Dictionary<string, int>
        {
            {"Sverige", 10}
        };
    }
}