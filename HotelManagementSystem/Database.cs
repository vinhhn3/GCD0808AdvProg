using System;
using System.Collections.Generic;

namespace HotelManagementSystem
{
  class Database : ISearch
  {
    private Dictionary<RoomType, List<Room>> _rooms;
    private Hotel _hotel;

    public Room CheckAvailability(decimal price, DateTime startDate, DateTime endDate, RoomType type)
    {
      throw new NotImplementedException();
    }

    public Database(Hotel hotel)
    {
      _hotel = hotel;
      _rooms = new Dictionary<RoomType, List<Room>>();
    }
  }
}
