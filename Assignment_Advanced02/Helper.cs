using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced02
{
    internal class Helper
    {
        public static void PrintList<T>(string Name,List<T> items)
        {
            Console.WriteLine($"{Name},{string.Join('\n',items)}");
        }

    }
}
