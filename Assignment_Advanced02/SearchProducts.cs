using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced02
{
    public class SearchProducts
    {
        public static List<Product> Search_Products(List<Product> catalog, Func<Product,bool> func)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in catalog)
            {
                if (func(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
    public class SearcchOperations
    {
       
       
        public  static bool GetCheaperthhan50(Product product)
        {
            return product.Price < 50;
        }
        public static bool GetStockGreaterThan0(Product product)
        {
            return product.Stock > 0;
        }
        public static bool GetClothingLessThan100(Product product)
        {
            return product.Category == "Clothing" && product.Price < 100;
        }
    }
}
