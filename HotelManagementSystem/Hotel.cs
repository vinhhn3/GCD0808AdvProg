namespace HotelManagementSystem
{
  class Hotel
  {
    private string _name;
    public string Name
    {
      get
      {
        return _name;
      }
      private set { }
    }

    public Hotel(string name)
    {
      _name = name;

    }
  }
}
