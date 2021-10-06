using System;

namespace Exceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
      int result = 0;

      try
      {
        result = a / b;
      }
      catch (Exception)
      {
        Console.WriteLine("Cannot divide 0");
      }

      Console.WriteLine(result);

      Console.ReadLine();

    }
  }
}
