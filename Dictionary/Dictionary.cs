// this is the first checkout
//Hello World
using System;
using System.Collections.Generic;

namespace HelloWorld
{

	public class Program
	{
		// This is the start of the program

	public static  void Main(string[] args)
		{

			Dictionary<string, string> dict = new Dictionary<string, string>();

			//Add (key, Value)
			dict.Add("C#", "cool");
			dict.Add("C++", "Like writing Sanskrit poetry in morse code");
			dict.Add("VB", "a simple but wordy language");
			dict.Add("Java", "good, but not c#");
			dict.Add("Fortran", "ANCNT");	// 6- letters-max variable name for "ancient"
			dict.Add("Cobol", "even more wordy, or is it wordier and verbose than VB");



			// See if the dictionary contains a particular key.
			Console.WriteLine("Contains key C# - " + dict.ContainsKey("C#")); // True
			Console.WriteLine("Containse key Ruby - " + dict.ContainsKey("Ruby")); // False

			// Iterate the dictionary's contentns with foreach
			// note that you're iterating pairs of keys and values

			Console.WriteLine("\nContents of the dictionary: ");
			foreach (KeyValuePair<string, string> pair in dict)
			{
				// Because the key happens to be a string we can call the string methods on it.
				Console.WriteLine("Key: " + pair.Key.PadRight(8) + "Value: " + pair.Value);
			}


		}
	}
}
