using System;
using System.Collections.Generic;

namespace Template

{
  class Program
  {
    static void Main(string[] args)
    {

      // Store Console Forground Color.
      // Console.ForegroundColor fgColor = new Console.ForegroundColor (fgColor);



      Console.ForegroundColor = ConsoleColor.Magenta;

      Console.WriteLine("\nFinding the overlap in towo lists: ");
      List<string> presentialCandidates = new List<string> {"Clinton", "Edwards", "Giuliani", "McCain", "Obama", "Romney"};

      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("List of Presidential Candidates");
      foreach (string senator in presentialCandidates)
      {
        Console.WriteLine(senator);
      }

      List<string> senators = new List<string> {"Alexander", "Boxer", "Clinton", "McCain", "Obama", "Snowe"};

      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("\nList of Senators");
      foreach (string senator in senators)
      {
        Console.WriteLine(senator);
      }

      HashSet<string> senatorsRunning = new HashSet<string> (presentialCandidates);

      // IntersectWith() collects items that appear in both lists, eliminates others.
      senatorsRunning.IntersectWith(senators);

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nList of Senators Running");
      foreach (string senator in senatorsRunning)
      {
        Console.WriteLine(senator);
      }

      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine();

      Console.WriteLine("\nFinding the unique cases");
      senatorsRunning.ExceptWith(presentialCandidates);
      foreach (string diff in presentialCandidates)
      {
        Console.WriteLine(diff);
      }


    }
  }
}
