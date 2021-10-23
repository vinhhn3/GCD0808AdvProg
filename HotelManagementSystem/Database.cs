using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagementSystem
{
  class Database : IDatabase
  {
    private Dictionary<RoomType, List<Room>> _rooms;
    private Hotel _hotel;

    public Room CheckAvailability(decimal price, DateTime startDate, DateTime endDate, RoomType type)
    {
      var room = _rooms[type].FirstOrDefault(r => r.Price == price &&
        r.IsAvailable(startDate, endDate) && !r.IsBooked
      );

      if (room == null)
      {
        room = _rooms[type].FirstOrDefault(r => r.Price == price);
      }
      return room;
    }

    public Database(Hotel hotel)
    {
      _hotel = hotel;
      _rooms = new Dictionary<RoomType, List<Room>>();
      _rooms[RoomType.DoubleBed] = new List<Room>();
      _rooms[RoomType.SingleBed] = new List<Room>();

    }

    public void AddRoom(int id, decimal price, RoomType type)
    {

      _rooms[type].Add(new Room(id, price, type));
    }

    public void Book(int roomId, DateTime startDate, DateTime endDate, RoomType type)
    {
      var room = _rooms[type].SingleOrDefault(t => t.Id == roomId);
      room.Book(startDate, endDate);
    }
  }
}
