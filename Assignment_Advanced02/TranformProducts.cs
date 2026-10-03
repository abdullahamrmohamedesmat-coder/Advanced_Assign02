using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced02
{
    public class TranformProducts
    {
        public static List<T> Transform_Products<T>(List<Product> catalog, Func<Product, T> func)
        {
            List<T> result = new List<T>();
            foreach (Product product in catalog)
            {
                result.Add(func(product));
            }
            return result;
        }

       
    }
  

}
