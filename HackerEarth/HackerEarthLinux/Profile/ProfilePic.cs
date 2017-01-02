using System;
namespace HackerEarth
{
	public class ProfilePic
	{
		public static void Main(string[] args)
		{
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
				foreach (string a in myArray) {
					Console.WriteLine (a);
				}
				

		}
	}
}