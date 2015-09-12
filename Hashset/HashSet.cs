using System;
using System.Collections.Generic;

namespace Template

{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Combining two collections withg no duplicates:");

      List<string> colors = new List<string>{"red", "orange", "yellow"};
      string[] moreColors = {"orange", "yellow", "green", "blue", "violet"};

      // Want to combine but without any duplicates
      //  Following is just the first stage ...

      HashSet<string> combined = new HashSet<string>(colors);

      // ... now the second stage
      //  UnionWith() collects items in both lists that aren't duplicated
      //  resulting in a combined collection whose members are all unique

      combined.UnionWith(moreColors);

      foreach(string color in combined)
      {
        Console.WriteLine(color);
      }

      Console.WriteLine("\nConverting the combined set to a list:");

      // Initialize a new List from the combined set above.
      List<string> spectrum = new List<string>(combined);

      foreach(string color in spectrum)
      {
        Console.WriteLine(color);
      }

      Console.WriteLine();


    }
  }
}
