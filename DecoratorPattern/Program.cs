using System;

namespace DecoratorPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      BlackCoffee blackCoffee = new BlackCoffee();
      blackCoffee.Show();

      // Decor
      MilkCoffee milkCoffee = new MilkCoffee(blackCoffee);
      milkCoffee.Show();

      LatteCoffee latteCoffee = new LatteCoffee(milkCoffee); // Base milkCoffee
      latteCoffee.Show();

      latteCoffee = new LatteCoffee(blackCoffee);
      latteCoffee.Show();

      Console.ReadLine();
    }
  }
}
