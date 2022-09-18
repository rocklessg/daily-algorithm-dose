using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class DrawingBookAlgo
    {
        /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

        public static int PageCount(int n, int p)
        {
            //int t1 = n - 1;
            //int t2 = t1 - p;
            //int t3 = t2 / 2;
            //return t3;
            return Math.Min(p / 2, n / 2 - p / 2);
        }

    }

    /*
     A teacher asks the class to open their books to a page number.
    A student can either start turning pages from the front of the
    book or from the back of the book. They always turn pages one
    at a time. When they open the book, page  is always on the right side:

    image

    When they flip page , they see pages  and .
    Each page except the last page will always be printed on both sides.
    The last page may only be printed on the front, given the length of
    the book. If the book is  pages long, and a student wants to
    turn to page , what is the minimum number of pages to turn?
    They can start at the beginning or the end of the book.

    Given n and p, find and print the minimum number of pages 
    that must be turned in order to arrive at page p.

    Example

    Function Description

    Complete the pageCount function in the editor below.

    pageCount has the following parameter(s):

    int n: the number of pages in the book
    int p: the page number to turn to
    Returns

    int: the minimum number of pages to turn
    Input Format

    The first line contains an integer , the number of pages in the book.
    The second line contains an integer, , the page to turn to.

    Constraints

    Sample Input 0

    6
    2
    Sample Output 0

    1
    Explanation 0

    If the student starts turning from page , they only need to turn  page:

    Untitled Diagram(6).png

    If a student starts turning from page , they need to turn  pages:

    Untitled Diagram(3).png

    Return the minimum value, .

    Sample Input 1

    5
    4
    Sample Output 1

    0
    Explanation 1

    If the student starts turning from page , they need to turn  pages:

    Untitled Diagram(4).png

    If they start turning from page , they do not need to turn any pages:

    Untitled Diagram(5).png

    Return the minimum value, .
        */
}
