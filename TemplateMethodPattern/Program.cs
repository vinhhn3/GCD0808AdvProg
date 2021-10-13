using System;

namespace TemplateMethodPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      AndroidBuilder androidBuilder = new AndroidBuilder();
      IosBuilder iOSBuilder = new IosBuilder();

      androidBuilder.Build();
      iOSBuilder.Build();

      Console.ReadLine();
    }
  }
}
