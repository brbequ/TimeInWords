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
    static string[] hours = 
    {
        "one",
        "two",
        "three",
        "four",
        "five",
        "six",
        "seven",
        "eight",
        "nine",
        "ten",
        "eleven",
        "twelve"
    };

    static string[] minutes =
    {
        "o' clock",
        "one",
        "two",
        "three",
        "four",
        "five",
        "six",
        "seven",
        "eight",
        "nine",
        "ten",
        "eleven",
        "twelve",
        "thirteen",
        "fourteen",
        "quarter",
        "sixteen",
        "seventeen",
        "eightteen",
        "nineteen",
        "twenty",
        "twenty one",
        "twenty two",
        "twenty three",
        "twenty four",
        "twenty five",
        "twenty six",
        "twenty seven",
        "twenty eight",
        "twenty nine",
        "half"
    };

    // Complete the timeInWords function below.
    static string timeInWords(int h, int m)
    {
        if (m == 0)
        {
            return String.Format("{0} {1}", hours[h - 1], minutes[0]);
        }
        return String.Format("{0}{1}{2}{3}",
            m <= 30 ? minutes[m] : minutes[60-m],
            m == 1 || m == 59 ? " minute" : m % 15 != 0 ? " minutes" : String.Empty,
            m <= 30 ? " past " : " to ",
            m <= 30 ? hours[h-1] : hours[h == 12 ? 0 : h]);
    }

    static void Main(string[] args)
    {
        //List<string> testcases = new List<string>
        //{
        //    "7:15",
        //    "3:00",
        //    "5:00",
        //    "5:01",
        //    "5:10",
        //    "5:15",
        //    "5:30",
        //    "5:40",
        //    "5:45",
        //    "5:47",
        //    "5:28",
        //};

        //foreach(string testcase in testcases)
        //{
        //    string[] temp = testcase.Split(":");
        //    int h = Convert.ToInt32(temp[0]);
        //    int m = Convert.ToInt32(temp[1]);

        //    string result = timeInWords(h, m);
        //    Console.WriteLine(result);
        //}

        for (int h = 1; h <= 12; h++)
        {
            for (int m = 0; m < 60; m++)
            {
                string result = timeInWords(h, m);
                Console.WriteLine(result);
            }
        }

    }
}
