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

class Solution {

    static void Main(string[] args) 
    {
        int[][] arr = new int[6][];
        
        int row = 6;
        int column = 6;
        int row_max = row - 2;
        int col_max = column - 2;
        int max = -100;

        for (int i = 0; i < 6; i++) 
        {
            //Read a string input (in the form of a row) fed in from the console.
            //Use LINQ method syntax to convert all elements in an array of one type to an array of a different type.
            //Store the converted values in the new 2d array 'arr' as the string (row) is now split by spaces to form individual columns.
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        
        //Find the top left value of the hourglass and calculate the sum of each hourglass.
        for(int i = 0; i < row_max; i++)
        {
            for(int j = 0; j < col_max; j++)
            {
                int sum = 
                (arr[i][j]) + 
                (arr[i][j + 1]) +
                (arr[i][j + 2]) + 
                (arr[i + 1][j + 1]) + 
                (arr[i + 2][j]) + 
                (arr[i + 2][j + 1]) + 
                (arr[i + 2][j + 2]);
    
                //Console.WriteLine("my sum: " + sum);
                max = Math.Max(max,sum);
                //if(sum > max)
                //{
                //    max = sum;
                //}
            }
        }
        Console.WriteLine(max);
    }
}
