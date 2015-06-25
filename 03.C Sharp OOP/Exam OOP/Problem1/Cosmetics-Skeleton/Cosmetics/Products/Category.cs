using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Category : ICategory
    {
        private string name;
        private ICollection<IProduct> cosmetic;

        public Category(string name)
        {
            this.Name = name;
            this.cosmetic = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name; 
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException(value, "Category name must be between 2 and 15 symbols long!");
                }
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.cosmetic.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            this.cosmetic.Remove(cosmetics);
        }

        public string Print()
        {
            var sortedProducts =
                this.cosmetic
                .OrderBy(c => c.Brand)
                .ThenByDescending(c => c.Price);

            var result = new StringBuilder();

            var numberOfProducts = this.cosmetic.Count;

            var pluralProductsMaybe =
                this.cosmetic.Count == 1
                ? "product"
                : "products";

            result.AppendLine(string.Format("{0} category - {1} {2} in total", this.Name, numberOfProducts, pluralProductsMaybe));
            
            foreach (var cosmetic in sortedProducts)
            {
                result.AppendLine(cosmetic.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
