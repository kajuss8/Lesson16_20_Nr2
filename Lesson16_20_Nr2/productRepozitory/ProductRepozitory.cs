using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_20_Nr2.productRepozitory
{
    internal class ProductRepozitory
    {
        public List<Product> Products { get; set; }
        //public ProductRepozitory()
        //{


        //}

        public ProductRepozitory()
        {
            Products = new List<Product>();
            Products.Add(new Product("Tomato", 0.25, 101, 1));
            Products.Add(new Product("Garlic", 0.11, 102, 1));
            Products.Add(new Product("Carrot", 0.32, 103, 1));
            Products.Add(new Product("Onion", 0.14, 104, 1));
            Products.Add(new Product("Potato", 0.15, 105, 1));

            Products.Add(new Product("Banana", 0.45, 201, 2));
            Products.Add(new Product("Apple", 0.61, 202, 2));
            Products.Add(new Product("Blueberry", 0.12, 203, 2));
            Products.Add(new Product("Cherry", 0.22, 204, 2));
            Products.Add(new Product("Lime", 0.73, 205, 2));

            Products.Add(new Product("Lamb", 4.99, 301, 3));
            Products.Add(new Product("Chicken", 2.99, 302, 3));
            Products.Add(new Product("Beef", 3.45, 303, 3));
            Products.Add(new Product("Pork", 1.99, 304, 3));

            Products.Add(new Product("Bun with fruit jam", 0.85, 401, 4));
            Products.Add(new Product("Bun with chocolate", 0.75, 402, 4));
            Products.Add(new Product("Sweet bun", 0.52, 403, 4));
            Products.Add(new Product("Cinnamon bun", 1.23, 404, 4));
            Products.Add(new Product("Bun with filling", 1.51, 405, 4));

            Products.Add(new Product("Fanta", 2.14, 501, 5));
            Products.Add(new Product("Water", 0.99, 502, 5));
            Products.Add(new Product("Coca cola", 2.48, 503, 5));
            Products.Add(new Product("Sprite", 1.89, 504, 5));
            Products.Add(new Product("Water with lemon", 1.19, 505, 5));
        }
        public List<Product> Retrieve()
        {
            return Products;
        }
        public Product Retrieve(int id)
        {
            return Products.Where(c => c.TypeOfProductId == id).FirstOrDefault();
        }
        public Product RetrieveProductId(int id)
        {
            return Products.Where(c => c.ProductId == id).FirstOrDefault();
        }
    }
}
