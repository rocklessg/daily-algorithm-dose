using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit.DictAndHashmap
{
    public class TripletsCount
    {
        static long CountTriplets(List<long> arr, long r)
        {
            var pairs = new Dictionary<long, long[]>();
            long triplets = 0;

            foreach (var n in arr)
            {
                if (!pairs.ContainsKey(n))
                {
                    pairs.Add(n, new long[] { 0, 0 });
                }

                if (n % r == 0 && pairs.ContainsKey(n / r))
                {
                    var prevPair = pairs[n / r];
                    triplets += prevPair[1];
                    pairs[n][1] += prevPair[0];
                }

                pairs[n][0]++;
            }

            return triplets;
        }
    }
}