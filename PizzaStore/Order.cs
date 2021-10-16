using System.Collections.Generic;
using System.Linq;

namespace PizzaStore
{
  class Order
  {
    private List<Pizza> _pizzas;
    private List<Drink> _drink;
    private List<Franchise> _franchises;

    public Order()
    {
      _pizzas = new List<Pizza>();
      _drink = new List<Drink>();
      _franchises = new List<Franchise>();
    }

    public void AddDrink(DrinkType type)
    {
      _drink.Add(new Drink(type));
    }

    public void AddFranchise(FranchiseType type)
    {
      _franchises.Add(new Franchise(type));
    }

    public void AddPizza(PizzaType pizzaType, PizzaSize size)
    {
      var pizza = new MargheritaPizza(size);
      switch (pizzaType)
      {
        case PizzaType.Margherita:

          _pizzas.Add(pizza);
          break;
        case PizzaType.Salami:
          var salamiPizza = new SalamiPizza(size, pizza);
          _pizzas.Add(salamiPizza);
          break;
        case PizzaType.Hawaiian:
          var hawaiianPizza = new HawaiianPizza(size, pizza);
          _pizzas.Add(hawaiianPizza);
          break;
        default:
          break;
      }
    }

    public double GetPrice()
    {
      return _drink.Sum(d => d.Price) + _franchises.Sum(d => d.Price) + _pizzas.Sum(p => p.GetPrice());
    }
  }
}
