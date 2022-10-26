using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_20_Nr2.product
{
    internal class ProductType
    {
        public string TypeOfProductName { get; set; }
        public int TypeOfProductId { get; set; }
        public ProductType(string typeOfProductName, int typeOfProductId)
        {
            TypeOfProductName = typeOfProductName;
            TypeOfProductId = typeOfProductId;
        }

    }
}
