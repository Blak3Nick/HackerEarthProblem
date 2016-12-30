using System;

namespace StringChallenge
{
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