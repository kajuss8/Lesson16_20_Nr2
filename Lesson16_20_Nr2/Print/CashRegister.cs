using Lesson16_20_Nr2.product;
using Lesson16_20_Nr2.productRepozitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_20_Nr2.Print
{
    internal class CashRegister
    {
        ProductRepozitory productRepozitory { get; set; }
        ProductTypeRepozitory productTypeRepozitory { get; set; }

        public CashRegister (ProductRepozitory _productRepozitory, ProductTypeRepozitory _productTypeRepozitory)
        {
            productRepozitory = _productRepozitory;
            productTypeRepozitory = _productTypeRepozitory;
        }

        public List<ReportBoughtProduct> PrintCashRegister()
        {
            List<Product> allProducts = productRepozitory.Retrieve();
            List<ProductType> allProductType = productTypeRepozitory.Retrieve();
            List<ReportBoughtProduct> boughtProductCounter = new List<ReportBoughtProduct>();
            double allProductSum = 0;

            
            while(true)
            {
                foreach(var productType in allProductType)
                {
                    Console.Write($"[{productType.TypeOfProductId}]-{productType.TypeOfProductName} ");
                }
                Console.WriteLine("[6]-check your list [7]-end your order");
                
                int chosenProductType = Convert.ToInt32(Console.ReadLine());
                
                if (chosenProductType == 1)
                {
                    foreach (var product in allProducts)
                    {
                        if (productRepozitory.Retrieve(chosenProductType).TypeOfProductId == product.TypeOfProductId)
                        {
                            Console.WriteLine($"[{product.ProductId}]-{product.ProductName} {product.ProductPrice}EUR");
                        }

                    }
                    int chosenProduct = Convert.ToInt32(Console.ReadLine());

                    foreach (var product in allProducts)
                    {

                        if (productRepozitory.RetrieveProductId(chosenProduct).ProductId == product.ProductId)
                        {
                            Console.Write($"your choice is {product.ProductName}, choose amount: ");
                            int amountOfProduct = Convert.ToInt32(Console.ReadLine());
                            Console.Write(amountOfProduct);
                            Console.WriteLine();
                            double tempSum = 0;
                            tempSum += product.ProductPrice * amountOfProduct;
                            allProductSum += tempSum;
                            Console.WriteLine($"{amountOfProduct}x{product.ProductName} {String.Format("{0:0.00}" ,tempSum)}EUR");
                            ReportBoughtProduct tempBoughtProductCounter = new ReportBoughtProduct();
                            tempBoughtProductCounter.ProductAmount = amountOfProduct;
                            tempBoughtProductCounter.ProductName = product.ProductName;
                            tempBoughtProductCounter.ProductAmountPrice = tempSum;
                            boughtProductCounter.Add(tempBoughtProductCounter);
                            

                        }
                        


                    }

                }
               


                if (chosenProductType == 2)
                {
                    foreach (var product in allProducts)
                    {
                        if (productRepozitory.Retrieve(chosenProductType).TypeOfProductId == product.TypeOfProductId)
                        {
                            Console.WriteLine($"[{product.ProductId}]-{product.ProductName} {product.ProductPrice}Eur");
                        }
                    }
                    int chosenProduct = Convert.ToInt32(Console.ReadLine());

                    foreach (var product in allProducts)
                    {

                        if (productRepozitory.RetrieveProductId(chosenProduct).ProductId == product.ProductId)
                        {
                            Console.Write($"your choice is {product.ProductName}, Choose amount: ");
                            int amountOfProduct = Convert.ToInt32(Console.ReadLine());
                            Console.Write(amountOfProduct);
                            Console.WriteLine();
                            double tempSum = 0;
                            tempSum += product.ProductPrice * amountOfProduct;
                            allProductSum += tempSum;
                            Console.WriteLine($"{amountOfProduct}x{product.ProductName} {String.Format("{0:0.00}", tempSum)}EUR");
                            ReportBoughtProduct tempBoughtProductCounter = new ReportBoughtProduct();
                            tempBoughtProductCounter.ProductAmount = amountOfProduct;
                            tempBoughtProductCounter.ProductName = product.ProductName;
                            tempBoughtProductCounter.ProductAmountPrice = tempSum;
                            boughtProductCounter.Add(tempBoughtProductCounter);


                        }

                    }

                }
               

                if (chosenProductType == 3)
                {
                    foreach (var product in allProducts)
                    {
                        if (productRepozitory.Retrieve(chosenProductType).TypeOfProductId == product.TypeOfProductId)
                        {
                            Console.WriteLine($"[{product.ProductId}]-{product.ProductName} {product.ProductPrice}Eur");
                        }
                    }
                    int chosenProduct = Convert.ToInt32(Console.ReadLine());

                    foreach (var product in allProducts)
                    {

                        if (productRepozitory.RetrieveProductId(chosenProduct).ProductId == product.ProductId)
                        {
                            Console.Write($"your choice is {product.ProductName}, Choose amount: ");
                            int amountOfProduct = Convert.ToInt32(Console.ReadLine());
                            Console.Write(amountOfProduct);
                            Console.WriteLine();
                            double tempSum = 0;
                            tempSum += product.ProductPrice * amountOfProduct;
                            allProductSum += tempSum;
                            Console.WriteLine($"{amountOfProduct}x{product.ProductName} {String.Format("{0:0.00}", tempSum)}EUR");
                            ReportBoughtProduct tempBoughtProductCounter = new ReportBoughtProduct();
                            tempBoughtProductCounter.ProductAmount = amountOfProduct;
                            tempBoughtProductCounter.ProductName = product.ProductName;
                            tempBoughtProductCounter.ProductAmountPrice = tempSum;
                            boughtProductCounter.Add(tempBoughtProductCounter);


                        }

                    }


                }
               

                if (chosenProductType == 4)
                {
                    foreach (var product in allProducts)
                    {
                        if (productRepozitory.Retrieve(chosenProductType).TypeOfProductId == product.TypeOfProductId)
                        {
                            Console.WriteLine($"[{product.ProductId}]-{product.ProductName} {product.ProductPrice}Eur");
                        }
                    }
                    int chosenProduct = Convert.ToInt32(Console.ReadLine());

                    foreach (var product in allProducts)
                    {

                        if (productRepozitory.RetrieveProductId(chosenProduct).ProductId == product.ProductId)
                        {
                            Console.Write($"your choice is {product.ProductName}, Choose amount: ");
                            int amountOfProduct = Convert.ToInt32(Console.ReadLine());
                            Console.Write(amountOfProduct);
                            Console.WriteLine();
                            double tempSum = 0;
                            tempSum += product.ProductPrice * amountOfProduct;
                            allProductSum += tempSum;
                            Console.WriteLine($"{amountOfProduct}x{product.ProductName} {String.Format("{0:0.00}", tempSum)}EUR");
                            ReportBoughtProduct tempBoughtProductCounter = new ReportBoughtProduct();
                            tempBoughtProductCounter.ProductAmount = amountOfProduct;
                            tempBoughtProductCounter.ProductName = product.ProductName;
                            tempBoughtProductCounter.ProductAmountPrice = tempSum;
                            boughtProductCounter.Add(tempBoughtProductCounter);


                        }

                    }


                }
               

                if (chosenProductType == 5)
                {
                    foreach (var product in allProducts)
                    {
                        if (productRepozitory.Retrieve(chosenProductType).TypeOfProductId == product.TypeOfProductId)
                        {
                            Console.WriteLine($"[{product.ProductId}]-{product.ProductName} {product.ProductPrice}Eur");
                        }
                    }
                    int chosenProduct = Convert.ToInt32(Console.ReadLine());

                    foreach (var product in allProducts)
                    {

                        if (productRepozitory.RetrieveProductId(chosenProduct).ProductId == product.ProductId)
                        {
                            Console.Write($"your choice is {product.ProductName}, Choose amount: ");
                            int amountOfProduct = Convert.ToInt32(Console.ReadLine());
                            Console.Write(amountOfProduct);
                            Console.WriteLine();
                            double tempSum = 0;
                            tempSum += product.ProductPrice * amountOfProduct;
                            allProductSum += tempSum;
                            Console.WriteLine($"{amountOfProduct}x{product.ProductName} {String.Format("{0:0.00}", tempSum)}EUR");
                            ReportBoughtProduct tempBoughtProductCounter = new ReportBoughtProduct();
                            tempBoughtProductCounter.ProductAmount = amountOfProduct;
                            tempBoughtProductCounter.ProductName = product.ProductName;
                            tempBoughtProductCounter.ProductAmountPrice = tempSum;
                            boughtProductCounter.Add(tempBoughtProductCounter);


                        }

                    }


                }

                if(chosenProductType == 6)
                {
                    foreach (var product in boughtProductCounter)
                    {
                        Console.WriteLine($"{product.ProductAmount}x{product.ProductName} {String.Format("{0:0.00}", product.ProductAmountPrice)}EUR");
                    }
                    Console.WriteLine($"Total price: {String.Format("{0:0.00}", allProductSum)}EUR");
                }
                
                if (chosenProductType == 7)
                {
                    foreach(var product in boughtProductCounter)
                    {
                        Console.WriteLine($"{product.ProductAmount}x{product.ProductName} {String.Format("{0:0.00}", product.ProductAmountPrice)}EUR");
                    }
                    Console.WriteLine($"Total price: {String.Format("{0:0.00}", allProductSum)}EUR");
                    break;
                }
                if (chosenProductType > 7)
                {
                    Console.WriteLine("This chose doesn't exist");
                    continue;
                }




            }
            Console.ReadKey();

            return boughtProductCounter;

        }


    }
}
