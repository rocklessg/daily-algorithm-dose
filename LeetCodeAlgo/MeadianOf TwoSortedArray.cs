using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgo
{
    public class MeadianOf_TwoSortedArray
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // 1 2 3 4 6
            var arrayList = new List<int>();
            arrayList.AddRange(nums1);
            arrayList.AddRange(nums2);

            int[] mergeNum = arrayList.ToArray();
            double numCount = mergeNum.Length;

            int middleNum = (int)Math.Round(numCount / 2);

            return numCount % 2 == 0 ? mergeNum[(int)(middleNum - 1)] + mergeNum[(int)(middleNum)] : mergeNum[(int)(middleNum)];



        }

    }

    // Given two sorted arrays nums1 and nums2 of size m and n respectively,
    // return the median of the two sorted arrays.

    //The overall run time complexity should be O(log (m+n)).



    //Example 1:

    //Input: nums1 = [1,3], nums2 = [2]
    //    Output: 2.00000
    //Explanation: merged array = [1, 2, 3] and median is 2.
    //Example 2:

    //Input: nums1 = [1,2], nums2 = [3,4]
    //    Output: 2.50000
    //Explanation: merged array = [1, 2, 3, 4] and median is (2 + 3) / 2 = 2.5.


    //Constraints:

    //nums1.length == m
    //nums2.length == n
    //0 <= m <= 1000
    //0 <= n <= 1000
    //1 <= m + n <= 2000
    //-106 <= nums1[i], nums2[i] <= 106

}
