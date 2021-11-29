using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit
{
    public class MinimumBribe
    {
        public static void MinimumBribes(List<int> q)
        {
            int ans = 0;
            int index = q.Count - 1;
            for (int i = index; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i]) ans++;
            }
            Console.WriteLine(ans);

        }
    }
}
