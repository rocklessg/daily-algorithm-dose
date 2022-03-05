using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    public class Qualified
    {
    }

    //For this exercise you will be strengthening your page-fu mastery.
    //You will complete the PaginationHelper class, which is a utility
    //class helpful for querying paging information related to an array.

    //The class is designed to take in an array of values and an integer
    //indicating how many items will be allowed per each page. The types
    //of values contained within the collection/array are not relevant.

    //The following are some examples of how this class is used:

    //var helper = new PaginationHelper<char>(new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);
    //helper.PageCount();      // should == 2
    //helper.ItemCount();      // should == 6
    //helper.PageItemCount(0); // should == 4
    //helper.PageItemCount(1); // last page - should == 2
    //helper.PageItemCount(2); // should == -1 since the page is invalid

    //// PageIndex takes an item index and returns the page that it belongs on
    //helper.PageIndex(5);     // should == 1 (zero-based index)
    //helper.PageIndex(2);     // should == 0
    //helper.PageIndex(20);    // should == -1
    //helper.PageIndex(-10);   // should == -1


    public class PaginationHelper<T>
    {
        public List<T> Collection { get; set; }
        public int ItemsPerPage { get; set; }

        public PaginationHelper(List<T> collection, int itemsPerPage)
        {
            Collection = collection;
            ItemsPerPage = itemsPerPage;
        }

        public int ItemCount()
        {
            return Collection.Count;
        }

        public int PageCount(int ItemsPerpage)
        {
            var result = Collection.Count - ItemsPerPage / 2;
            return result;
        }

        public int PageItemCount(int pageIndex)
        {
            if (pageIndex < 1)
            {
                return ItemsPerPage;
            }
            else if (pageIndex > 0 && pageIndex !> ItemsPerPage)
            {
                return ItemsPerPage - 2;
            }
            return -1;
        }

        public int PageIndex(int itemIndex)
        {
            // if should be use here to check
            // Algorithm time is up for now 
            return -1;
        }
    }
} 