using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

//         TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        string[] parts = s.Split(":");
        int hour = Convert.ToInt32(parts[0]);
        if (s.Contains("PM"))
        {
            hour = hour + 12;
            parts[0] = Convert.ToString(hour);
            string convertedString = string.Join(':', parts);
            convertedString = convertedString.Replace("PM", string.Empty);
            return convertedString;
        }
        if (s.Contains("AM"))
        {
            string convertedString = s.Replace("AM", string.Empty);
            return convertedString;
        }
        /*
         * Write your code here.
         */
        return "error";
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter("test.txt", true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
