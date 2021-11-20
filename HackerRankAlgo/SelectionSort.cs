using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    
    public class SelectionSort
    {
        public void SelectSort(int[] arr)
        {
            //pos_min is short for position of min
            int minimumPosition, temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                minimumPosition = i;//set pos_min to the current index of array

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minimumPosition])
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        minimumPosition = j;
                    }
                }

                //if pos_min no longer equals i then a smaller value must have been found, so a swap must occur
                if (minimumPosition != i)
                {
                    temp = arr[i];
                    arr[i] = arr[minimumPosition];
                    arr[minimumPosition] = temp;
                }
            }
        }
    }   
}
