using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagementSystem
{
  class Database : ISearch
  {
    private Dictionary<RoomType, List<Room>> _rooms;
    private Hotel _hotel;

    public Room CheckAvailability(decimal price, DateTime startDate, DateTime endDate, RoomType type)
    {
      var room = _rooms[type].FirstOrDefault(r => r.Price == price &&
        r.IsAvailable(startDate, endDate)
      );

      if (room == null)
      {
        room = _rooms[type].SingleOrDefault(r => r.Price == price);
      }
      return room;
    }

    public Database(Hotel hotel)
    {
      _hotel = hotel;
      _rooms = new Dictionary<RoomType, List<Room>>();
    }

    public void AddRoom(int id, decimal price, RoomType type)
    {
      if (!_rooms.ContainsKey(type))
      {
        _rooms[type] = new List<Room>();
        _rooms[type].Add(new Room(id, price, type));
      }

      _rooms[type].Add(new Room(id, price, type));
    }
  }
}
