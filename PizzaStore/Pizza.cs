using System.Collections.Generic;

namespace PizzaStore
{
  abstract class Pizza
  {
    protected double calorie;
    protected double price;
    protected PizzaSize size;
    public Pizza(PizzaSize size)
    {
      this.size = size;
      toppings = new Dictionary<ToppingType, List<Topping>>();
    }

    protected Dictionary<ToppingType, List<Topping>> toppings;

    public abstract double GetCalorie();
    public abstract double GetPrice();

    public void AddTopping(ToppingType type)
    {
      if (toppings[type] == null)
      {
        toppings.Add(type, new List<Topping>());
        toppings[type].Add(new Topping(type));
      }
      else
      {
        toppings[type].Add(new Topping(type));
      }
    }
  }
}
