using System;

namespace Exceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        var result = Divide(10, 5);
        Console.WriteLine(result);
      }
      catch (DivideByZeroException e)
      {
        Console.WriteLine(e.Message);
      }

      Console.ReadKey();

    }

    static int Divide(int a, int b)
    {
      if (b == 0)
      {
        throw new DivideByZeroException("Cannot divide Zero");
      }

      var result = a / b;
      return result;
    }
  }
}
