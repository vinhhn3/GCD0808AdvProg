using System;

namespace UnitTesting
{
  class Program
  {
    static void Main(string[] args)
    {
      var cal = new Calculator();
      int a = 10;
      int b = 20;
      int result = cal.Add(a, b); // 30
      Console.WriteLine(result);

      Console.ReadLine();
    }
  }
}
