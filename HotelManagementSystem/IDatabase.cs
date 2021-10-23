using System;

namespace HotelManagementSystem
{
  public interface IDatabase
  {
    Room CheckAvailability(decimal price, DateTime startDate, DateTime endDate, RoomType type);
    void Book(int roomId, DateTime startDate, DateTime endDate, RoomType type);
  }
}
