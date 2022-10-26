using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_20_Nr2
{
    internal class ReadingFromTextFile
    {

        //public List<Product> ReadAllProducts()
        //{
        //    string readingAllProducts = $"C:\\Users\\37067\\OneDrive\\Desktop\\C sharp basic\\Lesson16_20_Nr2\\Lesson16_20_Nr2\\AllProducts.txt";
        //    List<Product> products = new List<Product>();
        //    List<string> tempList = File.ReadAllLines(readingAllProducts).ToList();
        //    foreach(var line in tempList)
        //    {
        //        string[] entries = line.Split(' ');
        //        Product tempProduct = new Product();
        //        tempProduct.ProductName = entries[0];
        //        tempProduct.ProductPrice = Convert.ToDouble(entries[1]);
        //        tempProduct.ProductId = Convert.ToInt32(entries[2]);
        //        tempProduct.TypeOfProductId = Convert.ToInt32(entries[3]);

        //        products.Add(tempProduct);
        //    }
        //    //foreach(var product in products)
        //    //{
        //    //    Console.WriteLine($"{product.ProductName} {product.ProductPrice} {product.ProductId} {product.TypeOfProductId}");
        //    //}

        //    return products;
        //}

    }
}
