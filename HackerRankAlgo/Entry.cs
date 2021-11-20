using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    public class Entry
    {
        public static void RunApp()
        {
            List<List<int>> myList = new List<List<int>>();
            myList.Add(new List<int> { 25, 2, 20, 23 });
            myList.Add(new List<int> { 6, 7, 8, 43 });
            myList.Add(new List<int> { 5, 2, 10, 63 });
            myList.Add(new List<int> { 4, 4, 18, 6 });

            Console.WriteLine(TwoDMatrix.TwoDArray(myList));
        }
    }
}
