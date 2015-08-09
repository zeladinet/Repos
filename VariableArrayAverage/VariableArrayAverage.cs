// VariableArrayAverage -- Average an array whose size is
//    determined bu the user at runtime, accumulating the values
//    in an array. Allows them to be referenced as often as
//    desired. In this case, the array creates and attractive output.

namespace VariableArrayAverage
{
    using System;
    public class Program
    {
      public static void Main(string[] args)
      {
        // First read in the number of the doubles the user intends to enter.
        Console.Write("Enter the number of values to average: ");
        string numElements = Convert.ToInt32(numElementsInput);
        Console.WriteLine;

        // Now declare an array of that size.
        double[] doubleArray = new double[numElements]; // Here's the 'N'.

        // Accumulate the values into an array.
        for (int i = 0; i<numElements; i++)
        {
          // Prompt the user for another double.
          Console.Write("Enter double #" + (i + 1) + ": ");
          string val = Console.ReadLine();
          double value = Convert.ToDouble(val);

          // Add this to the array using bracket notation.
          doubleArray[i] = value;
        }
      }
    }
}
