using System;

namespace HotelManagementSystem
{
  class User
  {
    private string _fullName;
    private ISearch _iSearch;
    public string FullName
    {
      get
      {
        return _fullName;
      }
      private set { }
    }

    public User(string fullName, ISearch iSearch)
    {
      _fullName = fullName;
      _iSearch = iSearch;
    }

    public Room CheckAvailability(decimal price, DateTime startDate, DateTime endDate, RoomType type)
    {
      return _iSearch.CheckAvailability(price, startDate, endDate, type);
    }
  }
}
