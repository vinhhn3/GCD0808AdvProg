namespace PizzaStore
{
  class Franchise
  {
    private FranchiseType _type;
    private double _price;

    public double Price
    {
      get
      {
        return _price;
      }
      private set { }
    }

    public Franchise(FranchiseType type)
    {
      _type = type;
      switch (_type)
      {
        case FranchiseType.Shirt:
          _price = 21.99;
          break;
        case FranchiseType.Mug:
          _price = 4.99;
          break;
        default:
          break;
      }
    }
  }
}
