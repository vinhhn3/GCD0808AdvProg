namespace PizzaStore
{
  class Drink
  {
    private DrinkType _type;
    private double _price;
    private double _calorie;

    public double Price
    {
      get
      { return _price; }
      private set { }
    }

    public double Calorie
    {
      get
      {
        return _calorie;
      }
      private set { }
    }

    public Drink(DrinkType type)
    {
      _type = type;
      switch (_type)
      {
        case DrinkType.Lemonade:
          _calorie = 128;
          _price = 1.29;
          break;
        case DrinkType.Water:
          _calorie = 0;
          _price = 1.29;
          break;
        case DrinkType.Wine:
          _calorie = 607;
          _price = 7.49;
          break;
        default:
          break;
      }
    }
  }
}
