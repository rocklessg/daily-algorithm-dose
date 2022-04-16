using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miselleneous
{
    public static class BrainTeaser
    {
        public static void DoWhile()
        {
            int val = 5;
            do
            {
                val++;
                ++val;

            } while (val++ > 7);
            Console.WriteLine(val); // Guess the value of val
        }
    }
}
