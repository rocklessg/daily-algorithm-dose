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

        public static int FormatNumber(int number)
        {
            var binaryRep = string.Empty;
            var result = 0;
            while (number > 0)
            {
                binaryRep = (number % 10) + binaryRep;
                number = number / 10;
            }

            List<char> revstring = new List<char>();
            int binaryrepLen = binaryRep.Length;

            for (int i = binaryrepLen - 1; i >= 0; i--)
            {
                revstring.Add(binaryRep[i]);


                int base1 = 2;
                int len = revstring.Count;
                for (int j = 0; j < len; i++)
                {
                    if (binaryRep[i] == '1')
                        result += base1;
                    base1 = base1 * 10;
                }
            }

            return result;
        }


        // taltop
        public static List<int> miniChange(int a, int b)
        {
            // Write your code here
            var diff = a - b;
            var diffHundred = diff * 100;
            var listofDim = new List<int> { 1, 5, 10, 25, 50, 100 };
            var result = new List<int>();
            var count = 0;

            for (int i = listofDim.Count - 1; i >= 0; i--)
            {
                while (diffHundred >= listofDim[i])
                {
                    diffHundred -= listofDim[i];
                    count += 1;
                }
                result.Add(count);
                count = 0;
            }
            return result;
        }
    }

}
