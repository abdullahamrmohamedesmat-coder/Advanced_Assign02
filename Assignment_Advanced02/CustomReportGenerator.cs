using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced02
{
    public class CustomReportGenerator
    {
        //Customer report generator
        public static void PrintReport(List<Product> products, Action<Product> reportAction)
        {
            foreach (Product product in products)
            {
                reportAction(product);
                Console.WriteLine();
            }
        }
    }
    
}
