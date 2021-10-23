using System;

namespace HotelManagementSystem
{
  public class Room
  {
    private decimal _price;
    private bool _isBooked;
    private DateTime _startDate;
    private DateTime _endDate;
    private RoomType _type;

    public Room(decimal price, RoomType type)
    {
      _price = price;
      _type = type;
      _isBooked = false;
    }

    public bool IsAvailable(DateTime startDate, DateTime endDate)
    {
      return (startDate < _startDate && endDate < _startDate) ||
        (startDate > _endDate && endDate > _endDate);
    }
  }
}
