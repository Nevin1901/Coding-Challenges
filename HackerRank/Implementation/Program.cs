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

//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */


    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> finalGrades = new List<int>();
        //int[] finalGrades = { };
        for (int i = 0; i < grades.Count; i++)
        {
            int gradeI = Convert.ToInt32(grades[i]);
            if (gradeI < 38)
            {
                finalGrades.Add(gradeI);
                //finalGrades[i] = gradeI;
            }
            if (gradeI >= 38)
            {
                int gradeIRounded = Convert.ToInt32(Math.Ceiling(gradeI / 5.0) * 5);
                //int gradeIRounded = Convert.ToInt32(gradeI / 5 + 1) * 5;
                if (gradeIRounded - gradeI < 3)
                {
                finalGrades.Add(gradeIRounded);
                //finalGrades[i] = gradeIRounded;
                }
                if (gradeIRounded - gradeI > 3)
                {
                    finalGrades.Add(gradeI);
                    //finalGrades[i] = gradeIRounded;
                }
                if (gradeIRounded - gradeI == 3)
                {
                    finalGrades.Add(gradeI);
                }
            }

        }
        return finalGrades;
        
    }

}


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("test.txt", true);


        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
