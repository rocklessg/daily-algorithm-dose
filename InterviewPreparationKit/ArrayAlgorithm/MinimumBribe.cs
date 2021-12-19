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

        public static int[] SearchInSortedMatrix(int[][] matrix, int target)
        {
            int[] arr = new int[] {};

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                    {
                        if (matrix[i][j] == target)
                        {
                            arr.Append(matrix[i][j]);
                        }
                        arr.Append(-1);
                }
                arr.Append(-1);
            }
            return arr;
        }
// You're given a two-dimensional array (a matrix) of distinct integers and a target 
// integer. Each row in the matrix is sorted, and each column is also sorted; the 
// matrix doesn't necessarily have the same height and width.

//Write a function that returns an array of the row and column indices of the target integer if it's 
//contained in the matrix, otherwise [-1, -1].

//Challenge.SearchInSortedMatrix(matrix, target)
//Parameters
//matrix: Array<int[]> - A matrix of distinct integers

//target: int - The target integer to find in the matrix

//Return Value
//int[] - The row and column index of the target integer in the matrix.

//Given the matrix

//[
//  [1, 4, 7, 12, 15, 1000],
//  [2, 5, 19, 31, 32, 1001],
//  [3, 8, 24, 33, 35, 1002],
//  [40, 41, 42, 44, 45, 1003],
//  [99, 100, 103, 106, 128, 1004],
//]
//and a target value of 44, your function should return [3, 3].
//Meaning, the target value 44 can be found at row index 3 and column index 3 in the matrix.

//If the target value cannot be found in the matrix, you should return [-1, -1]
    }
}
