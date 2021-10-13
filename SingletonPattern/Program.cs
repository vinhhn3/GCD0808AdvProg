using System;

namespace SingletonPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      President a = President.GetInstance();
      President b = President.GetInstance();

      Console.WriteLine(a.Equals(b));   // true => only one President object is created

      Console.ReadLine();
    }
  }
}
