using System;

namespace PrimeNumberApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // I'm still confused with async/await in C#.
      // so I haven't found the proper solution for this exercise using it. I would need more time to research.
      // I use nested loop. The run time of this algorithm is O(n^2), not a great performance.

      Console.WriteLine("\nPrime numbers between 1 and 100 are:");

      bool isPrime = true;
      for (int i = 2; i <= 100; i++)
      {
        for (int j = 2; j <= 100; j++)
        {
          if (i != j && i % j == 0)
          {
            isPrime = false;
            break;
          }
        }

        if (isPrime)
        {
          Console.Write($"{i}  ");
        }
        isPrime = true;
      }

      Console.WriteLine("\n");
    }
  }
}
