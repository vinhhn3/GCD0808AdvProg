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

      var drink = new Drink(DrinkType.Lemonade);

      var shirt = new Franchise(FranchiseType.Shirt);

      var bigMac = new BigMac(salamiPizza, drink);

      Console.WriteLine("Price BigMac: " + bigMac.GetPrice());
      Console.WriteLine("Calorie BigMac: " + bigMac.GetCalorie());

      var order = new Order();
      order.AddDrink(DrinkType.Water);
      order.AddFranchise(FranchiseType.Mug);
      order.AddPizza(PizzaType.Hawaiian, PizzaSize.Family);

      Console.WriteLine("Order Price: " + order.GetPrice());



      Console.ReadLine();

    }
  }
}
