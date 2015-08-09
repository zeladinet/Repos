//  Build a Sentance -- The following program constructs sentance
//      by concantenating user input until the user enteres one of
//      the termingation characters. This program shows when you need to look for
//      string equality



using System;


namespace BuildASentance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Each line you enter will be added to a sentance until you enter Exit or Quite");
            
            // Ask the user for input; continue concatenating
            //      the phrases input until the user enters exit or
            //      quit (start with an empty sentance)
            
            string sentance = "";
            for (; ;)
            {
                // Get the next line
                Console.WriteLine("Enter a string ");
                string line = Console.ReadLine();
                // Exit the loop if line is a terminator.

                string[] terms = { "EXIT", "exit", "QUIT", "quit", "Quit", "Exit" };

                // Compare the string entered to each of the legal exit commands.
                bool quitting = false;

                foreach (string term in terms)
                {

                    // Break out of the for loop if you have a match.
                    if (string.Compare(line, term) == 0)
                    {
                        quitting = true;
                    }

                    if (quitting == true)
                    {
                        break;
                    }
                }
                // Otherwise, add it to the sentance.
                sentance = String.Concat(sentance, line);
                Console.WriteLine("\nyou've entered: " + sentance);
                //Let the user know how she's doing.

            }
                
                
                Console.ReadLine();
                
                
                
           
            

        }
    }
}
