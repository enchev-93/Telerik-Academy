using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Toothpaste : Products, IToothpaste
    {
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name ,brand, price, gender)
        {
            this.ingredients = ingredients;
        }

        public string Ingredients { get; set; }

        public override string ToString()
        {
            var result = string.Format("  * Ingredients: {0}", this.ingredients);

            return result.ToString().TrimEnd();
        }
    }
}
