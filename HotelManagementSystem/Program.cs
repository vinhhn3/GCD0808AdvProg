using System;

namespace HotelManagementSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      Hotel hotel = new Hotel("Furama");
      Database database = new Database(hotel);

      database.AddRoom(1, 100, RoomType.DoubleBed);
      database.AddRoom(2, 200, RoomType.DoubleBed);
      database.AddRoom(3, 300, RoomType.DoubleBed);
      database.AddRoom(4, 400, RoomType.DoubleBed);
      database.AddRoom(5, 500, RoomType.DoubleBed);
      database.AddRoom(6, 600, RoomType.DoubleBed);

      database.AddRoom(10, 50, RoomType.SingleBed); // => Booked
      database.AddRoom(11, 50, RoomType.SingleBed); 
      database.AddRoom(12, 50, RoomType.SingleBed);
      database.AddRoom(13, 50, RoomType.SingleBed);
      database.AddRoom(14, 50, RoomType.SingleBed);
      database.AddRoom(15, 50, RoomType.SingleBed);
      database.AddRoom(16, 50, RoomType.SingleBed);

      User user = new User("Vinh Hoang", database);

      var room = user.CheckAvailability(100, new DateTime(2021, 11, 15), new DateTime(2021, 11, 30), RoomType.DoubleBed);

      room.Show(); // Id = 1

      room = user.CheckAvailability(50, new DateTime(2021, 11, 15), new DateTime(2021, 11, 30), RoomType.SingleBed);

      room.Show(); // Id = 10

      user.Book(10, new DateTime(2021, 11, 15), new DateTime(2021, 11, 30), RoomType.SingleBed); // RoomId = 10 => booked

      room = user.CheckAvailability(50, new DateTime(2021, 11, 15), new DateTime(2021, 11, 30), RoomType.SingleBed);

      room.Show(); // => Id = 11

      Console.ReadLine();
    }
  }
}
