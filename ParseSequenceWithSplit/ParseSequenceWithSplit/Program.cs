namespace ParseSequenceWithSplit

{
using System;

    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to input a sequence of numbers. 
            Console.WriteLine("Input a series of numbers seperated by commas: ");

            //Read a line of text.
            string input = Console.ReadLine();

            Console.WriteLine();

            //Now convert the line into individual segments based upon either comas or spaces.
            char[] dividers = { ',', ' ' };
            string[] segments = input.Split(dividers);

            //convert each segment into a number
            int sum = 0;
            foreach (string s in segments)
            {
                //skip any empty segments.

            if (s.Length > 0)
                {
                    //skip strings that aren't numbers
                    if (IsAllDigits(s))
                    {
                        // convert the string into a 32-bit int
                        int num = 0;
                        if (Int32.TryParse(s, out num))
                        {
                            Console.WriteLine("Next Number = {0}", num);

                            //add this number into the sum.
                            sum += num;
                        }
                        //if parse fails move onto the next number
                    }

                }


            }

            //output the sum.

            Console.WriteLine("Sum = {0}", sum);

            //Wait for the user to acknowledge the results.
            Console.Read();


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
