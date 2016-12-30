using System;

namespace StringChallenge
{
    public class MainProgram 
    {

       
        public static void Main(string[] args)
        {
            string myLines(){
                return line1;
            }
            public string line1 {get; set;}
            string line2 = Console.ReadLine();
            line1 = line2;
            string line3 = line1.ToLower();
            bool isUpper;
            string line4;
            for (int i =0; i<line1.Length; i++)
                {
                 if(line1[i]!=line2[i])
                 {
                     line1[i]=line2[i];}
                 else{}
                }
            Console.WriteLine(line1[0]);
                   
        }
        public class stringToUpper 
        {
            string holder;
            public string change (char[] x)
             {
                for (int i =0; i<x.Length; i++)
                {
                    holder+= x[i].ToString();
                }
             return holder;
             }     
               
        }
    }
    
}