using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLinq
{
    public class LinqTest
    {
        public void LinqMethod()
        {


            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6, };


            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numberQuery = from number in numbers
                              where (number % 2) == 0
                              select number;


        //The from clause specifies the data source, the where clause
        //applies the filter, and the select clause specifies the
        //type of the returned elements

            // 3. Query execution.
            foreach (int num in numberQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }
    }
}
