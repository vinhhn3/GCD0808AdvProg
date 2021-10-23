using System;

namespace HotelManagementSystem
{
  public class Room
  {
    private int _id;
    private decimal _price;
    private bool _isBooked;
    private DateTime _startDate;
    private DateTime _endDate;
    private RoomType _type;

    public decimal Price
    {
      get
      {
        return _price;
      }
      private set { }
    }

    public int Id
    {
      get
      {
        return _id;
      }

      private set { }
    }

    public bool IsBooked
    {
      get { return _isBooked; }
      private set { }
    }

    public Room(int id, decimal price, RoomType type)
    {
      _id = id;
      _price = price;
      _type = type;
      _isBooked = false;
    }

    public bool IsAvailable(DateTime startDate, DateTime endDate)
    {
      return (startDate < _startDate && endDate < _startDate) ||
        (startDate > _endDate && endDate > _endDate) && !_isBooked;
    }

    public void Book(DateTime startDate, DateTime endDate)
    {
      _isBooked = true;
      _startDate = startDate;
      _endDate = endDate;
    }

    public void Show()
    {
      Console.WriteLine("======================");
      Console.WriteLine(_id);
      Console.WriteLine(_price);
    }
  }
}
