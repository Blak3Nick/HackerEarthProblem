using System;
using System.Collections.Generic;

namespace StringChallenge
{
    public class MainProgram 
    {

       
        public static void Main(string[] args)
        {
        string line1 = Console.ReadLine();
        string line2 = line1.ToUpper();
        string line3 = line1.ToLower();
        List<char> myList = new List<char>();
        for (int i =0; i<line1.Length;i++)
        {
            if(line1[i]==line2[i])
            {
                char a = line3[i];
                myList.Add(a);
                
            }
            else
            {
               char b = line2[i];
               myList.Add(b);
            }
        }
        foreach(char c in myList)
        {
            Console.Write(c);
        }
        Console.WriteLine(line1);
               
        }
    }
    
}