using System;
using System.Collections.Generic;
namespace HackerEarth
{
	public class ProfilePic
	{
		public static void Main(string[] args)
		{
			/*[1] If any of the width or height is less than L, user is prompted to upload another one. Print "UPLOAD ANOTHER" in this case.
			[2] If width and height, both are large enough and
			(a) if the photo is already square then it is accepted. Print "ACCEPTED" in this case.
			(b) else user is prompted to crop it. Print "CROP IT" in this case. */
			char[] paraams = {' ' };
			string[] myArray = new string[5];
			string L = Console.ReadLine ();
			int Lint = Int32.Parse (L);
			string W = Console.ReadLine ();
			int Wint = Int32.Parse (W);
			int counter = Wint;
			while (counter != 0) {
				

				Array.Resize (ref myArray, Wint);

				for (int i = 0; i < Wint; i++) {
					myArray [i] = Console.ReadLine ();
					counter--;
				}

			}
			string[] doubled = new string[Wint * 2];
			List<string> myList = new List<string>();
			for (int i = 0; i < Wint; i++) {
				myList.Add( myArray [i].Split (paraams));
			}
			foreach (string a in myList) {
					Console.WriteLine (a);
				}
				

		}
	}
}