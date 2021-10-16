namespace PizzaStore
{
  class SalamiPizza : Pizza
  {
    private MargheritaPizza _basePizza;
    public SalamiPizza(PizzaSize size, MargheritaPizza basePizza) : base(size)
    {
      _basePizza = basePizza;
      calorie = 1160;
      price = 5.99;
    }

    public override double GetPrice()
    {
      return _basePizza.GetToppingsPrice() + GetToppingsPrice()
        + (size == PizzaSize.Family ? price + 4.15 : price);
    }

    public override double GetCalorie()
    {
      return _basePizza.GetToppingsCalorie() + GetToppingsCalorie()
        + (size == PizzaSize.Family ? calorie * 1.95 : calorie);
    }
  }
}
