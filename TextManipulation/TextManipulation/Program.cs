using System;
namespace IsAllDigits

{
    class Program
    {
        static void Main(string[] args)
        {
            //IsAllDigits  -- Return tru if all characters
            //  in the string are digits

            //Master Branch

            //Enter a string from the keyboard...
            Console.WriteLine("Enter an integer number");
            string s = Console.ReadLine();

            //First check to see if this could be a number.
            if(!IsAllDigits(s))
            {
                Console.WriteLine("Hey! that isn't a number");
            }
            else
            {
                //Convert the string into an integer
                int n = Int32.Parse(s);

                //Now write out the number times 2
                Console.WriteLine("2 * " + n + " = " + (2 * n));
            }
            Console.ReadLine();
            
        }

        public static bool IsAllDigits(string raw)
            {
                string s = raw.Trim();  //ignore white space on either side
                if (s.Length == 0) return false;

                //Loop through the string

                for (int index = 0; index < s.Length; index++)
                {
                    // A nondigit indicates that the string probabluy isn't a number
                    if (Char.IsDigit(s[index]) == false) return false;
                }

               //No nondigits found; it's probably okay.
                return true;

            }


    }
}
