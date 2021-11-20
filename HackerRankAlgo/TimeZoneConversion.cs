using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    public class TimeZoneConversion
    {
        public static string TimeConversion(string s)
        {
            //first solution
            return DateTime.Parse(s).ToString("HH:mm:ss");
            //==========


            //Another Solution pseudo code
            //int hour = your hour value;
            //int min = your minute value;
            //String ampm = your am / pm value;

            //hour = ampm == "AM" ? hour : (hour % 12) + 12; //convert 12-hour time to 24-hour

            //var dateTime = new DateTime(0, 0, 0, hour, min, 0);
            //var timeString = dateTime.ToString("HH:mm");




            //string ampm = s.Substring(s.Length - 2);
            //string hour = s.Substring(0, 2);
            //string minute = s.Substring(3, 5);
            //string second = s.Substring(6, 8);
            //int hours;


            // if (ampm.ToUpper() == "PM" && hour != "12")
            //     hours = Convert.ToInt32(hour) + 12;
            // else if (ampm.ToUpper() == "PM" && hour == "12")
            //     hours = 12;
            // else if (ampm.ToUpper() == "AM" && hour == "12")
            //     hours = 00;


            // return $"{hour}:{minute}:{second}";


        }
    }
//Given a time in -hour AM/PM format, convert it to military(24-hour) time.

//Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
//- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

//Example

//Return '12:01:00'.

//Return '00:01:00'.

//Function Description


//Complete the timeConversion function in the editor below.It should 
//    return a new string representing the input time in 24 hour format.

//timeConversion has the following parameter(s):


//string s: a time in hour format
//Returns


//string: the time in hour format
//Input Format


//A single string that represents a time in -hour clock format (i.e.:  or ).

//Constraints

//All input times are valid
//Sample Input 0

//07:05:45PM
//Sample Output 0

//19:05:45
}
