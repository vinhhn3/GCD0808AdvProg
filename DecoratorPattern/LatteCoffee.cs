using System;

namespace DecoratorPattern
{
  class LatteCoffee : ICoffee
  {
    private ICoffee _baseCoffee;
    public LatteCoffee(ICoffee baseCoffee)
    {
      _baseCoffee = baseCoffee;
    }
    public int GetCost()
    {
      return _baseCoffee.GetCost() + 4;
    }

    public string GetDescription()
    {
      return _baseCoffee.GetDescription() +
        " with latte added ...";
    }
    public void Show()
    {
      Console.WriteLine("===============");
      Console.WriteLine($"Cost: {GetCost()}");
      Console.WriteLine($"Description: {GetDescription()}");
    }
  }
}
