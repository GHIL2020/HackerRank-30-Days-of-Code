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
    static void Main(string[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int result = n;
        int remainder = 0;
        int count = 0;
        int max = 0;
        
        while(result > 0)
        {
            remainder = result % 2;
            result = result / 2;
             
            if(remainder == 1)
            {
                count = count + 1;
                if(count > max)
                {
                    max = count;
                }
            }
            else
            {
                count = 0;
            }
        }
        Console.WriteLine(max);
    }
}
