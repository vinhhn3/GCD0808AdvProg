using System;

namespace HotelManagementSystem
{
  public interface ISearch
  {
    Room CheckAvailability(decimal price, DateTime startDate, DateTime endDate, RoomType type);
  }
}
