using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the compareTriplets function below.
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int aScore = 0;
        int bScore = 0;
        for (int i = 0; i < a.Capacity; i++)
        {
            if (a[i] < b[i])
                bScore++;
            if (a[i] > b[i])
                aScore++;
        }
        List<int> totalScore = new List<int>();
        totalScore.Add(aScore);
        totalScore.Add(bScore);
        return totalScore;
        // return answer, answer
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("test.txt", true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
