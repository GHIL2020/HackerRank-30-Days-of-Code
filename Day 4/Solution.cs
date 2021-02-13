using System;
using System.Collections.Generic;
using System.IO;

class Person {
    public int age;     
    
    public Person(int initialAge) {
 
        if(initialAge > 0)
        {
           age = initialAge; 
        }
        else if (initialAge < 0)
        {
            age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
     }
     
    public void amIOld() {
        if(age >= 18) 
        {
            Console.WriteLine("You are old.");
        } 
        else if(age >= 13 && age < 18) 
        {
            Console.WriteLine("You are a teenager.");
        } 
        else if(age >= 0 && age <= 12) 
        {
            Console.WriteLine("You are young.");
        } 
     }

     public void yearPasses() {
         age = age + 1;
     }

static void Main(String[] args) {
