using Lesson16_20_Nr2.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_20_Nr2.productRepozitory
{
    internal class ProductTypeRepozitory
    {
        public List<ProductType> ProductTypes { get; set; }
        public ProductTypeRepozitory()
        {
            ProductTypes = new List<ProductType>();
            ProductTypes.Add(new ProductType("Vegetable", 1));
            ProductTypes.Add(new ProductType("Fruit", 2));
            ProductTypes.Add(new ProductType("Meat", 3));
            ProductTypes.Add(new ProductType("Sweet bun", 4));
            ProductTypes.Add(new ProductType("Drinks", 5));
        }

        public List<ProductType> Retrieve()
        {
            return ProductTypes;
        }
        public ProductType Retrieve(int id)
        {
            return ProductTypes.Where(c => c.TypeOfProductId == id).FirstOrDefault();
        }

    }
}
