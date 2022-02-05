using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miselleneous
{
    public static class ReverseArray
    {
        public static string[] ArrayReverseUnderTheHood(string[] arrayToReverse)
        {
            List<string> result = new();
            int arrayToReverseLength = arrayToReverse.Length;

            for (int i = arrayToReverseLength - 1; i >= 0; i--)
            {
                result.Add(arrayToReverse[i]);
            }
            return result.ToArray();
        }
    }
}
