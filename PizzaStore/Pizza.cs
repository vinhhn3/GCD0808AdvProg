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

    public virtual double GetCalorie()
    {
      double totalCalorie = 0;
      if (size == PizzaSize.Family)
      {
        totalCalorie = calorie * 1.95;
      }
      else
      {
        totalCalorie = calorie;
      }

      return totalCalorie + GetToppingsCalorie();
    }
    public virtual double GetPrice()
    {
      double totalPrice;
      if (size == PizzaSize.Family)
      {
        totalPrice = price + 4.15;
      }
      else
      {
        totalPrice = price;
      }

      return totalPrice + GetToppingsPrice();
    }

    public void AddTopping(ToppingType type)
    {
      if (!toppings.ContainsKey(type))
      {
        toppings.Add(type, new List<Topping>());
        toppings[type].Add(new Topping(type));
      }
      else
      {
        toppings[type].Add(new Topping(type));
      }
    }

    public double GetToppingsPrice()
    {
      double toppingsPrice = 0;
      foreach (var toppingType in toppings)
      {
        foreach (var topping in toppingType.Value)
        {
          toppingsPrice = toppingsPrice + topping.Price;
        }
      }

      return toppingsPrice;
    }

    public double GetToppingsCalorie()
    {
      double toppingsCalorie = 0;
      foreach (var toppingType in toppings)
      {
        foreach (var topping in toppingType.Value)
        {
          toppingsCalorie = toppingsCalorie + topping.Calorie;
        }
      }

      return toppingsCalorie;
    }
  }
}
