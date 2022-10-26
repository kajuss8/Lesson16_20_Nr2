using Lesson16_20_Nr2.Print;
using Lesson16_20_Nr2.productRepozitory;
using System;
using System.Collections.Generic;

namespace Lesson16_20_Nr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            ProductRepozitory productRepozitories = new ProductRepozitory();
            ProductTypeRepozitory productTypeRepozitories = new ProductTypeRepozitory();
            CashRegister cashRegister = new CashRegister(productRepozitories, productTypeRepozitories);
            var tem = cashRegister.PrintCashRegister();
            WriteInTextFile writeInTextFile = new WriteInTextFile();
            writeInTextFile.PrintBoughtProduct(tem);
            writeInTextFile.PrintProductPrices(tem);
        }
    }
}
