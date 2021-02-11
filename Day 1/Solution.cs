using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int number;
        double bignumber;
        string word;
        
        // Read and save an integer, double, and String to your variables.
        //number = Convert.ToInt32(Console.ReadLine());
        number = int.Parse(Console.ReadLine());
        bignumber = double.Parse (Console.ReadLine());
        word = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + number);
        
        // Print the sum of the double variables on a new line.
        bignumber = d + bignumber;
        Console.WriteLine("{0:F1}", bignumber);
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + ""  + word);

    }
