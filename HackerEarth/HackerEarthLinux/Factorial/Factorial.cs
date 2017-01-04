using System;
public class Factorial
{
	public static void Main(string[] args)
	{
		var input = Console.ReadLine ();
		int myInt = Int32.Parse (input);
		int toReturn = 1;
		int[] myArray = new int[myInt];
		for (int i = myInt; i > 1; i--) {
			myArray [i - 1] = i;

		}
		myArray[0] = 1;
		foreach (int a in myArray) {
			toReturn = toReturn * a;
		}
		Console.WriteLine (toReturn);
	}
}