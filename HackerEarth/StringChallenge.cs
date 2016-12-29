using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerEarth
{

    public class StringChallenge
    {
        public string aString = "abcdE";

        public string[] returnString()
        {
            string[] substring = aString.Split();
            foreach (string letter in substring)
            {
                letter.ToUpper();
            }
            return substring;
        } 
        


    }
}
