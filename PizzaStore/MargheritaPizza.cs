namespace PizzaStore
{
  class MargheritaPizza : Pizza
  {
    public MargheritaPizza(PizzaSize size) : base(size)
    {

      calorie = 1104;
      price = 4.99;

      if (size == PizzaSize.Family)
      {
        calorie = calorie * 1.95;
        price = price + 4.15;
      }
    }

    public override double GetCalorie()
    {
      return calorie;
    }

    public override double GetPrice()
    {
      return price;
    }
  }
}
