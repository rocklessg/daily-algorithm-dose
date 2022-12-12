using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miselleneous
{
    public class UnderHoodOfSortingElements
    {
        public static List<int> SortArray(List<int> listToSort)
        {
            var sortedList = new List<int>();
            //int firstIndex = listToSort.First();
            int firstIndex = listToSort.Max();

            for (var i = 0; i < listToSort.Count; i++)
            {
                if (listToSort[i] <= firstIndex && !sortedList.Contains(listToSort[i]))
                {
                    firstIndex = listToSort[i];
                    sortedList.Add(listToSort[i]);
                }
                else
                {
                    //sortedList.Add(listToSort[i]);
                    firstIndex = listToSort[i];
                    //continue;
                }
            }
            return sortedList;

        }

        public static void BubbleSort(int[] arr)
        {
            // Loop through the array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Loop through the array again, starting from the end
                for (int j = arr.Length - 1; j > i; j--)
                {
                    // Swap the elements if they are out of order
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }

    }
}
