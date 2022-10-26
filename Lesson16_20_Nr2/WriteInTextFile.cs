using Lesson16_20_Nr2.Print;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_20_Nr2
{
    internal class WriteInTextFile
    {

        
        public void PrintBoughtProduct(List<ReportBoughtProduct> reportBoughtProduct)
        {
            
            string productsThatWasBought = @"C:\Users\37067\OneDrive\Desktop\C sharp basic\Lesson16_20_Nr2\Lesson16_20_Nr2\ProductsThatWasBought.txt";
            File.WriteAllText(productsThatWasBought, "");
            foreach (var product in reportBoughtProduct)
            {
                File.AppendAllText(productsThatWasBought, $"{product.ProductAmount}x{product.ProductName}\n");
                
            }
            

        }
        public void PrintProductPrices(List<ReportBoughtProduct> reportBoughtProduct)
        {

            string productPrices = @"C:\Users\37067\OneDrive\Desktop\C sharp basic\Lesson16_20_Nr2\Lesson16_20_Nr2\ProductPrices.txt";
            File.WriteAllText(productPrices, "");
            double tempSum = 0;
            foreach (var product in reportBoughtProduct)
            {
                File.AppendAllText(productPrices, $"{product.ProductAmount}x{product.ProductName} {string.Format("{0:0.00}", product.ProductAmountPrice)}EUR\n");
                tempSum += product.ProductAmountPrice;
            }
            File.AppendAllText(productPrices, $"Total cost: {string.Format("{0:0.00}", tempSum)}EUR");
        }
    }
}
