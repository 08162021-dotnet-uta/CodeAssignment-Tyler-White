using System;
using System.Collections.Generic;

namespace SweetnSalty
{
  class Program
  {
    static void Main(string[] args)
    {
      int sweetCount = 0;
      int saltyCount = 0;
      int sweentNSaltyCount = 0;
      List<string> printTen = new List<string>();

      for (int i = 1; i <= 1000; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          sweentNSaltyCount++;
          printTen.Add("sweet’n’Salty");
        }
        else if (i % 5 == 0)
        {
          saltyCount++;
          printTen.Add("salty");
        }
        else if (i % 3 == 0)
        {
          sweetCount++;
          printTen.Add("sweet");
        }
        else printTen.Add(i.ToString());

        if (printTen.Count == 10)
        {
          foreach (string SNS in printTen)
          {
            Console.Write($"{SNS} ");
          }
          Console.WriteLine("");
          printTen = new List<string>();
        }
      }
      foreach (string SNS in printTen)
      {

        Console.Write($"{SNS} ");
      }
      Console.WriteLine("");
      Console.WriteLine($"Sweet Count: {sweetCount}");
      Console.WriteLine($"Salty Count: {saltyCount}");
      Console.WriteLine($"SweetNSaly Count: {sweentNSaltyCount}");
    }
  }
}
