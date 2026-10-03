using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced02
{
    public class FilterProducts
    {
        public static List<Product> Filter_Products(List<Product> catalog,Predicate<Product> predicate)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in catalog)
            {
                if (predicate(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
    public class FilterOperations
    {
     public static bool LowStockAlert(Product product)
        {
            if(product.Stock<20)
            {
                Console.WriteLine($"Only {product.Stock} left!");
            }
            return product.Stock < 20;
        }
    }
}
