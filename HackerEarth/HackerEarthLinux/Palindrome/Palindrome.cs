using System;
namespace HackerEarth{
public class Palindrome{
    public static void Main(string[] args)
    {
        //check whether a given input is a Palindrome or can be read the same back to front
        string input = Console.ReadLine();
        string holder = reverseString(input);
        if (holder == input)
        {
            Console.WriteLine("YES");
        }
        else {
            Console.WriteLine("NO");
        }

    }
        public static string reverseString(string s)
        {
            char[] w = s.ToCharArray();
            Array.Reverse(w);
            return new string(w);
        }
    }
}