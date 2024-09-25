/*
Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.

Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

Function Description

Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

timeConversion has the following parameter(s):

string s: a time in 12 hour format
Returns

string: the time in 24 hour format
Input Format

A single string  that represents a time in -hour clock format (i.e.:hh:mm:ssAM  or hh:mm:ssPM).

Constraints

All input times are valid
Sample Input 0

07:05:45PM
Sample Output 0

19:05:45
*/

namespace HackerRankAlgorithms.Algorithms
{
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            string convertedTime = "";

            if (s.Contains("AM"))
            {
                if (s.Substring(0, 2) == "12")
                {
                    convertedTime = "00" + s.Substring(2, 6);
                }
                else
                {
                    convertedTime = s.Substring(0, 8);
                }
            }
            else
            {
                if (s.Substring(0, 2) == "12")
                {
                    convertedTime = s.Substring(0, 8);
                }
                else
                {
                    int hour = int.Parse(s.Substring(0, 2));
                    hour += 12;
                    convertedTime = hour.ToString() + s.Substring(2, 6);
                }
            }

            return convertedTime;
        }
    }
}
