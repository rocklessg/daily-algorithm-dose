using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualified
{
    public class PlacementReadiness
    {
        public static List<string> FindProcesses(string start_item, string end_item, List<string> tasks)
        {
            var newList = new List<string>();
            var emptyList = new List<string>();

            if (start_item == end_item)
            {
                return emptyList;
            }
            else if (start_item != end_item || !tasks.Contains(end_item))
            {
                return emptyList;
            }

            for (var i = 0; i <= tasks.Count; i++)
            {
                if (tasks[i].Contains(start_item) || tasks[i].Contains(end_item))
                {
                    newList.Add(tasks[i]);
                }
            }
            return newList;
        }

    }


    //Task
    //For this challenge, you will be finding the most efficient 
    // set of steps to get from one item to another.

    //Inputs
    //You will write a function which will be provided with a
    //set of processes that each convert from one item to another.

    //These will be provided as an array, with each process in the
    //form of "process_name:from_item:to_item". For example, you might
    //have a process named "smelt" that converts ore into a metal, like
    //this: "smelt:ore:metal".

    //You will also be passed in the initial start item and desired 
    //end item for the overall workflow.

    //Note: For simplicity, all processes and items will be simple 
    //alphanumeric strings.

    //Output
    //Given these three inputs, your task is to determine which 
    //processes will complete the task in the shortest number of steps.
    //Once you have done so, return the names of these processes, in order, as an array.

    //If no steps are needed (because the start and end item is the same), 
    //or if you cannot find a valid set of processes to get from the start to the end, 
    //return an empty array.

    //Specification
    //Challenge.CountChange(startItem, endItem, tasks)
    //Parameters
    //startItem: string - Item to start with

    //endItem: string - Item to try to reach

    //tasks: string[] - A mapping of strings from one item to another in the format 
    //"process_name:from_item:to_item"

    //Return Value
    //string[] - A list of processes that convert start item to end item, 
    //if it exists

    //Examples
    //start_item  end_item tasks   Return Value
    //"field"	"bread"	["gather:field:wheat","bake:flour:bread","mill:wheat:flour"] ["gather","mill","bake"]
    //"field"	"ferrari"	["gather:field:wheat","bake:flour:bread","mill:wheat:flour"] []
    //"field"	"field"	["gather:field:wheat","bake:flour:bread","mill:wheat:flour"] []
}
