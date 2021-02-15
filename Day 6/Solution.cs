using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(string[] args) 
    {
        int T = Convert.ToInt32(Console.ReadLine());
        
        string [] argsArray = new string[T];  
        string even = ""; 
        string odd = ""; 

        for(int i = 0; i < T; i++)
        {
            argsArray[i] = Console.ReadLine();
            Char[] CharArr = argsArray[i].ToCharArray();
            
            for(int j = 0; j < CharArr.Length; j++)
            {
                if((j % 2) == 0 )
                {
                    even = even + CharArr[j];
                }
                
                if((j % 2) != 0)
                {
                    odd = odd + CharArr[j];
                }
            }
            Console.Write(even + " " + odd);
            even = "";
            odd = "";
            Console.WriteLine();
        }    
    }
}
