using System;
public class PrintHacker
{
	public static void Main(string[] args)
	{
		var input = Console.ReadLine ();
		int strLength = Int32.Parse (input);
		var strInput = Console.ReadLine ();
		//hackerearth a*2 h*2 c*1 k*1 e*2 r*2 t*1
		// position of List { a, c, e, h, k, r, t }
		char[] charrArray = new char[strLength];
		for (int i =0; i<strLength-1; i++) {
			charrArray [i] = strInput [i];
		}
		int[] numOfChars = new int[7];
		for (int i =0; i<strLength-1; i++) {
			if (charrArray[i].ToString() == "a") {
				numOfChars [0] += 1;
			} else if (charrArray[i].ToString()  == "c") {
				numOfChars [1] += 1;
			} else if (charrArray[i].ToString()  == "e") {
				numOfChars [2] += 1;
			} else if (charrArray[i].ToString()  == "h") {
				numOfChars [3] += 1;
			} else if (charrArray[i].ToString()  == "k") {
				numOfChars [4] += 1;
			} else if (charrArray[i].ToString()  == "r") {
				numOfChars [5] += 1;
			} else if (charrArray[i].ToString() == "t") {
				numOfChars [6] += 1;
			} else {
			}
		}
		foreach (var n in numOfChars) {
			Console.WriteLine (n);
		}
	}
}