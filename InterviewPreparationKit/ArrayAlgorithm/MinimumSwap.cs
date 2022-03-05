//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InterviewPreparationKit
//{
//    public static class MinimumSwap
//    {
//        public static int MinimumSwaps(int[] arr)
//        {
//            int count = 0;
//            for (int i = 0; i < arr.Length - 1; i++)
//            {
//                int currentVal = arr[i];
//                while (currentVal != i + 1)
//                {
//                    int temp = arr[currentVal - 1];
//                    arr[currentVal - 1] = currentVal;
//                    currentVal = temp;
//                    count++;
//                }
//            }
//            return count;
//        }
//    }

// You are given an unordered array consisting of consecutive
//integers[1, 2, 3, ..., n] without any duplicates.You are 
//allowed to swap any two elements.Find the minimum number 
//of swaps required to sort the array in ascending order.


//Example


//Perform the following steps:


//i arr                         swap (indices)
//0   [7, 1, 3, 2, 4, 5, 6] swap (0,3)
//1   [2, 1, 3, 7, 4, 5, 6]
//    swap(0,1)
//2   [1, 2, 3, 7, 4, 5, 6]
//    swap(3,4)
//3   [1, 2, 3, 4, 7, 5, 6]
//    swap(4,5)
//4   [1, 2, 3, 4, 5, 7, 6]
//    swap(5,6)
//5   [1, 2, 3, 4, 5, 6, 7]
//    It took  swaps to sort the array.

//    Function Description

//Complete the function minimumSwaps in the editor below.

//minimumSwaps has the following parameter(s) :

//int arr[n]: an unordered array of integers
//Returns

//int: the minimum number of swaps to sort the array
//Input Format

//The first line contains an integer, , the size of.
//The second line contains  space-separated integers.

//Constraints

//Sample Input 0

//4
//4 3 1 2
//Sample Output 0

//3
//Explanation 0

//Given array
//After swapping  we get
//After swapping  we get
//After swapping  we get
//So, we need a minimum of swaps to sort the array in ascending order.

//Sample Input 1

//5
//2 3 4 1 5
//Sample Output 1

//3
//Explanation 1

//Given array
//After swapping  we get
//After swapping  we get
//After swapping  we get
//So, we need a minimum of swaps to sort the array in ascending order.

//Sample Input 2

//7
//1 3 5 2 4 6 7
//Sample Output 2

//3
//Explanation 2

//Given array
//After swapping  we get
//After swapping  we get
//After swapping  we get
//So, we need a minimum of swaps to sort the array in ascending order.

//}

using System;
using System.Collections.Generic;

class MainClass
{

    public static string ArrayChallenge(int[] arr)
    {

        // code goes here 
        var list1 = new List<int>();
        var n = new HashSet<int>();

        n.Add(0);
        n.Add(1);
        n.Add(1);
        var dict = new Dictionary<int, int>(); 
        dict.Add(0, 1);
        dict.Add(1, 2);
        dict.Add(2, 3);
        dict[4] = 9;


        var list2 = new List<int>();
        var lastIndex = arr.Length - 1;
        var intersect = new List<int>();


        for (int i = arr[0]; i <= arr[1]; i++)
        {
            list1.Add(i);
        }

        for (int j = arr[2]; j <= arr[3]; j++)
        {
            list2.Add(j);
        }

        for (int i = 0; i <= list1.Count; i++)
        {
            if (list2.Contains(list1[i]))
            {
                intersect.Add(list1[i]);

            }
        }

        if (intersect.Count >= lastIndex)
        {
            return "true";
        }


        return "false";

    }

    
    }


