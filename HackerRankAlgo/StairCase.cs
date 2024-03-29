﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    public class StairCase
    {
        public static void StairCCase(int n)
        {
            var message = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0," + n + "}", message += "#");
            }

            // Js simple staircase
            //for (string row = "#"; row.Length <= n; row+= "#")
            //{
            //    Console.WriteLine(row);
            //}
        }
    }

//    Staircase detail

//This is a staircase of size :

//   #
//  ##
// ###
//####
//Its base and height are both equal to.It is drawn using # symbols and spaces. The last line is not preceded by any spaces.

//Write a program that prints a staircase of size.

//Function Description

//Complete the staircase function in the editor below.

//staircase has the following parameter(s):

//int n: an integer
//Print

//Print a staircase as described above.

//Input Format

//A single integer, , denoting the size of the staircase.

//Constraints

// .

//Output Format

//Print a staircase of size  using # symbols and spaces.

//Note: The last line must have spaces in it.

//Sample Input

//6 
//Sample Output

//     #
//##
//###
//####
//#####
//######
}
