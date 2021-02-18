using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int arguments = 0;
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        
        arguments = Convert.ToInt32(Console.ReadLine());
                
        for(int i = 0; i < arguments; i++)
        {
            var s = Console.ReadLine().Split(' ');
            phoneBook.Add(s[0],s[1]); 
        }
        
        string present;
        while((present = Console.ReadLine()) != null)
        {
            if(phoneBook.ContainsKey(present) == true)
            {
                Console.WriteLine(present + "=" + phoneBook.[present]);
            }
            else
            {
                Console.WriteLine("Not found");
            }      
        }
    }
}
