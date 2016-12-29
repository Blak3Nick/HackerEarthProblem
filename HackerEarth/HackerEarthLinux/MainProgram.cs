using System;

namespace StringChallenge
{
    public class MainProgram 
    {

       
        public static void Main(string[] args)
        {
            string line1;
            line1 = Console.ReadLine();
            string[] arrayString = new string[50];
            char[] arryChar = line1.ToCharArray();
            char[] myArray = new char[50];
            foreach(char s in arryChar)
            {
                arryChar = Char.ToUpper(s);
            }
            //Console.WriteLine(line1);
            Console.WriteLine(arryChar);
        }
    }
    
}