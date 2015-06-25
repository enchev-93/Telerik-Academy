using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : Products, IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters { get; set; }

        public Common.UsageType Usage { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            result.AppendLine(string.Format("  * Usage: {0}", this.Usage));
            return result.ToString().TrimEnd();
        }
    }
}
