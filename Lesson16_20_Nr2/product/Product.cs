using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_20_Nr2
{
    internal class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductId { get; set; }
        public int TypeOfProductId { get; set; }

        public Product(string productName, double productPrice, int productId, int typeOfProductId)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductId = productId;
            TypeOfProductId = typeOfProductId;
        }



    }
}
