using System;

namespace IsAllDigits
{
	class Program
	{
		public static void Main (string[] args)
		{
			// Input a string from the keyboard.
			Console.WriteLine ("Enter an integer number");
            string s = Console.ReadLine ();

			// First check to see if this could be a number.
			if (!IsAllDigits (s)) { // Call the special method.
				Console.WriteLine ("Hey! that isn't a number");
			} 

			else 
			{
				// Convert the string into an integer.
				int n = Int32.Parse(s);

				// Now write out the number of times 2.
				Console.WriteLine("2 * " + n + " = " + (2 * n));

			}
	
			Console.ReadLine ();


	}		
		

		// IsAllDigits -- Return true if all characters
		//	in the string are digits.
		public static bool IsAllDigits(string raw)
		{
			// First get rid of any benign characters at either end;
			//	if there's nothing left, you don't have a number.
			string s = raw.Trim ();	// Ignore white space on either side.

			if (s.Length == 0) {
				return false;
			}
			else
			{
				// Loop through the string.
				for (int index = 0; index < s.Length; index++) {
				// A nondigit indicates the string probably isn't a number
					if (char.IsDigit(s[index]) == false) return false;

				}
			}


			return true;

		}	



	}
}
