using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Advanced02
{
    internal class Helper
    {
        //Helper method to pr
        public static void PrintList<T>(string Name,List<T> items)
        {
            Console.WriteLine($"{Name},{string.Join('\n',items)}");
        }

    }
}
