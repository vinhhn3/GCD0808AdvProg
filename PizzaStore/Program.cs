using System;

namespace PizzaStore
{
  class Program
  {
    static void Main(string[] args)
    {
      var margheritaPizza = new MargheritaPizza(PizzaSize.Family);

      Console.WriteLine("Price " + margheritaPizza.GetPrice());
      Console.WriteLine("Calorie " + margheritaPizza.GetCalorie());

      Console.ReadLine();

    }
  }
}
