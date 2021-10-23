using System;

namespace AirlineReservationSystem
{
  class User
  {
    private Guid _id;
    public string Email;
    public string Password;
    private IAirline _iAirline;

    public User(string email, string password, IAirline iAirline)
    {
      _id = new Guid();
      Email = email;
      Password = password;
      _iAirline = iAirline;
    }

    public void View()
    {
      _iAirline.ShowAllFlights();
    }

    public Ticket Book(string flightId)
    {
      return _iAirline.BookTicket(flightId, _id);
    }

    public bool Cancel(int ticketId, string flightId)
    {
      var offSet = 1;
      return _iAirline.Cancel(flightId, ticketId - offSet);
    }
  }
}
