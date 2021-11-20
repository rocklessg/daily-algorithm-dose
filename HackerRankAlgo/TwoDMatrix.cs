using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    public class TwoDMatrix
    {
        public static int TwoDArray(List<List<int>> arr)
        {
            int leftDiagonal = 0;
            int rightDiagonal = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                leftDiagonal += arr[i][i];
                rightDiagonal += arr[i][arr[i].Count - 1 - i];
            }
            return Math.Abs(leftDiagonal - rightDiagonal);
        }
    }
}
