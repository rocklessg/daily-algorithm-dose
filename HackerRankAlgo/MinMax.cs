using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    public class MinMax
    {
        public static void MiniMaxSum(List<int> arr)
        {

            long minimumSum = 0;
            long maximumSum = 0;
            bool isFirstloop = true;

            for (int i = 0; i < arr.Count; i++)
            {
                long countContainer = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i != j)
                    {
                        countContainer += arr[j];

                    }
                }

                if (isFirstloop)
                {

                    minimumSum = countContainer;
                    maximumSum = countContainer;
                    isFirstloop = false;
                }
                else
                {
                    if (countContainer < minimumSum)
                    {
                        minimumSum = countContainer;

                    }
                    else if (countContainer > maximumSum)
                    {
                        maximumSum = countContainer;
                    }
                }
            }

            Console.WriteLine($"{minimumSum} {maximumSum}");


            //    arr.Sort();

            //    int minimumSum = 0;
            //    int maximumSum = 0;

            //    for (int i = 0; i < arr.Count - 1; i++)
            //    {
            //        minimumSum += arr[i];
            //    }

            //    for (int j = 1; j <= arr.Count - 1; j++)
            //    {
            //        maximumSum += arr[j];
            //    }

            //    Console.WriteLine($"{minimumSum} {maximumSum}");
        }
    }
}

//Given five positive integers, find the minimum and maximum values 
//that can be calculated by summing exactly four of the five integers. 
//    Then print the respective minimum and maximum values as a single 
//    line of two space-separated long integers.

//Example

//The minimum sum is  and the maximum sum is . The function prints

//16 24
//Function Description

//Complete the miniMaxSum function in the editor below.

//miniMaxSum has the following parameter(s):

//arr: an array of integers
//Print

//Print two space-separated integers on one line: the minimum sum and the maximum 
//  sum of  of  elements.

//Input Format

//A single line of five space-separated integers.

//Constraints


//Output Format

//Print two space-separated long integers denoting the respective minimum and maximum 
//    values that can be calculated by summing exactly four of the five integers. 
//    (The output can be greater than a 32 bit integer.)

//Sample Input

//1 2 3 4 5
//Sample Output

//10 14
