namespace PizzaStore
{
  class BigMac
  {
    private Pizza _pizza;
    private Drink _drink;

    public BigMac(Pizza pizza, Drink drink)
    {
      _pizza = pizza;
      _drink = drink;
    }

    public double GetPrice()
    {
      return _pizza.GetPrice() + _drink.Price;
    }

    public double GetCalorie()
    {
      return _pizza.GetCalorie() + _drink.Calorie;
    }
  }
}
