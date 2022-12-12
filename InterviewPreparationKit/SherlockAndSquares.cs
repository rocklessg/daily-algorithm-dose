using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit
{
    public static class SherlockAndSquares
    {
        // this solution is not passing all test case
        // Due to optimization
        public static int Squares(int a, int b)
        {
            var counter = 0;
            for (var i = a; i <= b; i++)
            {
                var holder = i;
                var sRoot = Math.Round(Math.Sqrt(holder));
                if (sRoot * sRoot == holder )
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}

/*Watson likes to challenge Sherlock's math ability.
 * He will provide a starting and ending value that
 * describe a range of integers, inclusive of the
 * endpoints. Sherlock must determine the number of
 * square integers within that range.

Note: A square integer is an integer which is the
square of an integer, e.g.[1,4,9,16,25] .

Example
a = 24
b = 49

There are three square integers in the range:
25, 25 and 49. Return 3.

Function Description

Complete the squares function in the editor below.
It should return an integer representing the number
of square integers in the inclusive range from a to b.

squares has the following parameter(s):

int a: the lower range boundary
int b: the upper range boundary
Returns

int: the number of square integers in the range
Input Format

The first line contains , the number of test cases.
Each of the next  lines contains two space-separated
integers,  and , the starting and ending integers in the ranges.

Constraints



Sample Input

2
3 9
17 24
Sample Output

2
0
Explanation

Test Case #00: In range [3,9], 4 and 9 are the two square integers.
Test Case #01: In range [17,24], there are no square integers.*/
