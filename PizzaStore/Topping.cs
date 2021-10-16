namespace PizzaStore
{
  class Topping
  {
    private ToppingType _type;
    private int _calorie;
    private double _price;

    public int Calorie
    {
      get
      {
        return _calorie;
      }
      private set { }
    }

    public double Price
    {
      get
      {
        return _price;
      }
      private set { }
    }

    public Topping(ToppingType type)
    {
      _type = type;

      switch (_type)
      {
        case ToppingType.Cheese:
          _calorie = 92;
          _price = 0.69;
          break;
        case ToppingType.Ham:
          _calorie = 35;
          _price = 0.99;
          break;
        case ToppingType.Onion:
          _calorie = 22;
          _price = 0.69;
          break;
        case ToppingType.Pineapple:
          _calorie = 24;
          _price = 0.79;
          break;
        case ToppingType.Salami:
          _calorie = 86;
          _price = 0.99;
          break;
        default:
          break;
      }
    }
  }
}
