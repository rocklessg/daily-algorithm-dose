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
            int firstIndex = listToSort.First();

            for (var i = 1; i < listToSort.Count; i++)
            {
                if (listToSort[i] <= firstIndex)
                {
                    firstIndex = listToSort[i];
                    sortedList.Add(firstIndex);
                }
                else
                {
                    sortedList.Add(listToSort[i]);
                    firstIndex = listToSort[i];
                }
            }
            return sortedList;

        }
    }
}
