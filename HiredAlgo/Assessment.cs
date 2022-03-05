using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HiredAlgo
{
    public class Assessment
    {
        public static long Solution(long[] prices)
        {
            // Type your solution here
            long buyingPrice = 0;
            long sellingPrice = 0;
            long result = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] <= buyingPrice)
                {
                    buyingPrice = prices[i];
                }
                else if (prices[i] > sellingPrice)
                {
                    sellingPrice = prices[i];
                }
                result = sellingPrice - buyingPrice;
            }

            return result;
        }
    }
}

