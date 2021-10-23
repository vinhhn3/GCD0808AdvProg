using System;

namespace HotelManagementSystem
{
  class User
  {
    private string _fullName;
    private IDatabase _iDatabase;
    public string FullName
    {
      get
      {
        return _fullName;
      }
      private set { }
    }

    public User(string fullName, IDatabase iDatabase)
    {
      _fullName = fullName;
      _iDatabase = iDatabase;
    }

    public Room CheckAvailability(decimal price, DateTime startDate, DateTime endDate, RoomType type)
    {
      return _iDatabase.CheckAvailability(price, startDate, endDate, type);
    }

    public void Book(int roomId, DateTime startDate, DateTime endDate, RoomType type)
    {
      _iDatabase.Book(roomId, startDate, endDate, type);
    }
  }
}
