using System;

namespace PizzaStore
{
  class Program
  {
    static void Main(string[] args)
    {
      var margheritaPizza = new MargheritaPizza(PizzaSize.Normal);

      Console.WriteLine("Price " + margheritaPizza.GetPrice());
      Console.WriteLine("Calorie " + margheritaPizza.GetCalorie());

      margheritaPizza.AddTopping(ToppingType.Cheese);

      var salamiPizza = new SalamiPizza(PizzaSize.Family, margheritaPizza);

      salamiPizza.AddTopping(ToppingType.Ham);

      Console.WriteLine("Price " + salamiPizza.GetPrice());
      Console.WriteLine("Calorie " + salamiPizza.GetCalorie());



      Console.ReadLine();

    }
  }
}
