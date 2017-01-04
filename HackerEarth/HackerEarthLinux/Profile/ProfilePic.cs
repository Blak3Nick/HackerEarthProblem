using System;
using System.Collections.Generic;
namespace HackerEarth
{
	public class ProfilePic
	{
		public static void Main(string[] args)
		{
			char[] paraams = {' ' };
			string L = Console.ReadLine ();
			//L holds the minimum value that a picture must have for width and height
			int Lint = Int32.Parse (L);
			string N = Console.ReadLine ();
			//Wint holds the number of picture dimensions that will follow
			int Wint = Int32.Parse (N);
			int counter = Wint;
			while (counter != 0) {

				for (int i = 0; i < Wint; i++) {
					var input = Console.ReadLine ();
					string[] myString = input.Split(paraams);
					int[] myInt = new int[2];
					myInt[0] = Int32.Parse(myString[0]);
					myInt[1] = Int32.Parse(myString[1]);
					if (myInt [0] < Lint || myInt [1] < Lint) {
						Console.WriteLine ("UPLOAD ANOTHER");
					} else if (myInt [0] != myInt [1]) {
						Console.WriteLine ("CROP IT");
					} else {
						Console.WriteLine ("ACCEPTED");
					}

					counter--;
				}

			}
		}
	}
}