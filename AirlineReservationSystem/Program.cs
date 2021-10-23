using System;

namespace AirlineReservationSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      var airline = new Airline("Delay Airline");
      airline.CreateFlight("HN - SGN");
      airline.CreateFlight("SGN - DAN");

      var user = new User("vinh@gmail.com", "123", airline);

      user.View();

      user.Book("HN - SGN");
      user.Book("HN - SGN");
      user.Book("HN - SGN");
      user.Book("HN - SGN");

      user.View();

      user.Cancel(3, "HN - SGN");

      user.View();

      Console.ReadLine();
    }
  }
}
