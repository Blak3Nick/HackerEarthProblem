using System;

public class CountDivisors
{
    static void Main(string[] args)
    {
		//Take in 3 space separated ints and find how many ints between the first 2 ints are divisible by the 3rd int including the 2 ints
		//holder used for running total of divisible ints
		int holder = 0;

		var input = Console.ReadLine();
        char[] params2 = {' '};
		string[] inputString = input.Split(params2);
		//array to hold the numbers
		int[] intArray = new int[3];
		for (int i = 0; i < inputString.Length; i++) 
		{
			intArray[i] = Int32.Parse (inputString [i]);
		}
		//new array to hold all ints between the first two ints
		int[] intArray2 = new int[intArray[1]-intArray[0]+1];
		intArray2 [intArray2.Length - 1] = intArray [1];
		int j = intArray[1] - intArray[0];

		for (int i = 0; i < intArray2.Length; i++) {
			intArray2 [i] = intArray [1] - j;
			j--;
		}

//		foreach (int i in intArray2) {
//		
//			Console.WriteLine (i);
//		}

		foreach (int b in intArray2) {
			if (b % intArray [2] == 0) {
				holder += 1;
			} else {
				//do nothing
			}
		}
		Console.WriteLine (holder);
	

     }
}