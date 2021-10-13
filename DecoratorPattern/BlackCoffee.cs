using System;

namespace DecoratorPattern
{
  class BlackCoffee : ICoffee
  {
    public int GetCost()
    {
      return 5;
    }

    public string GetDescription()
    {
      return "This is Black Coffee";
    }

    public void Show()
    {
      Console.WriteLine("===============");
      Console.WriteLine($"Cost: {GetCost()}");
      Console.WriteLine($"Description: {GetDescription()}");
    }
  }
}
