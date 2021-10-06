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
      catch (DivideByZeroException e)
      {
        Console.WriteLine(e.Message);
      }

      Console.WriteLine(result);

      string str = Console.ReadLine();

      try
      {
        int.Parse(str);
      }

      catch (FormatException e)
      {
        Console.WriteLine(e.Message);
      }

      catch (OverflowException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        Console.WriteLine("Code cleaned up ...");
      }


      Console.WriteLine("Code after try-catch-finally block");

      Console.ReadLine();

    }
  }
}
