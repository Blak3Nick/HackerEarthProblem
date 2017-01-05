using System;
using System.Collections.Generic;
public class MagicWord 
{
	public static void Main(string[] args)
	{
		/*input is int for # of test cases next int for string length of test case
			convert the ASCI II value for each char in each test case to nearest ASCI II prime valued character 
			return the new "word" for each case
			prime = 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127
		*/
		string numOfTests = Console.ReadLine ();
		int intTests = Int32.Parse (numOfTests);
		int counter = intTests;
		int secondCount;
		while (counter != 0)
		{
			secondCount = 1;
			while (secondCount != 0) {
				var input1 = Console.ReadLine ();
				int Input1 = Int32.Parse (input1);
				var input2 = Console.ReadLine ();
				List<char> myList = new List<char> ();
				foreach (char a in input2) {
					myList.Add (a);
				}
				List<int> intList = new List<int> ();
				for (int i=0; i<Input1;i++) {
					intList.Add ((int)myList[i]);
				}
				foreach (int a in intList) {
					int i = a;
					if(i<=69){Console.Write ("C");}
					else if(i<=72){Console.Write("G");}
					else if(i<=76){Console.Write("I");}
					else if(i<=81){Console.Write("O");}
					else if(i<=86){Console.Write("S");}
					else if(i<=93){Console.Write("Y");}
					else if(i<=99){Console.Write("a");}
					else if(i<=102){Console.Write("e");}
					else if(i<=105){Console.Write("g");}
					else if(i<=108){Console.Write("k");}
					else if(i<=111){Console.Write("m");}
					else {Console.Write("q");}
									}
				secondCount--;
			}
			counter--;	
		}



	}
}