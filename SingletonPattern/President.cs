namespace SingletonPattern
{
  class President
  {
    private static President _instance;
    private President()
    {

    }

    public static President GetInstance()
    {
      if (_instance == null)
      {
        _instance = new President();
      }
      return _instance;
    }
  }
}
