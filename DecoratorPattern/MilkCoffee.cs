using System;

namespace DecoratorPattern
{
  class MilkCoffee : ICoffee
  {
    private ICoffee _baseCoffee;
    public MilkCoffee(ICoffee baseCoffee)
    {
      _baseCoffee = baseCoffee;
    }
    public int GetCost()
    {
      return _baseCoffee.GetCost() + 2;
    }

    public string GetDescription()
    {
      return _baseCoffee.GetDescription() +
        " with milk added ...";
    }

    public void Show()
    {
      Console.WriteLine("===============");
      Console.WriteLine($"Cost: {GetCost()}");
      Console.WriteLine($"Description: {GetDescription()}");
    }
  }
}
