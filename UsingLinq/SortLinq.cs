using System;
using System.Linq;
using System.Collections.Generic;

namespace UsingLinq
{
    public class SortLinq
    {
        public static void Sort()
        {
            var nums = new List<int> { 2, 1, 8, 0, 4, 3, 5, 7, 9 };

            var enum2 = from num in nums
                        orderby num
                        select num;
            foreach (var item in enum2)
            {
                Console.Write(item);
            }
        }
    }
}
