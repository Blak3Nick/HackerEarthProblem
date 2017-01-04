using System;
public class MagicWord 
{
	public static void Main(string[] args)
	{
		/*rewrite small numbers from input to output. Stop processing input after reading in the number 42. 
		 * All numbers at input are integers of one or two digits.*/
		string stop = "43";
		while (stop != "42") {
			stop = Console.ReadLine ();
			if (stop != "42") {
				Console.WriteLine (stop);
			} else {
			}

		}
	}
}