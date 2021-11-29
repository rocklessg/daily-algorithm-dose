using System;
using System.Collections.Generic;

namespace Miselleneous
{
    public class UnderHoodOfMathDotMax
    {
        public static int GetMax(List<int> list)
        {
            int max = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
           return max;
        }
    }
}
