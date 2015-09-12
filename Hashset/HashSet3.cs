using System;
using System.Collections.Generic;

namespace HashSet3

{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\nExcluding items from the list");
      Queue<int> queue = new Queue<int>(new int[] {0,1,2,3,4,5,6,7,8,9,17});
      HashSet<int> unique = new HashSet<int>{1,3,5,7,9,11,13,15};

      //ExceptWith() removes the items in the uniquethat are also in the queue: 1, 3, 5, 7
      unique.ExceptWith(queue);

      foreach (int n in unique)
      {
        Console.WriteLine(n.ToString());
      }


    }
  }
}
