using System;
using System.Collections.Generic;
using System.Linq;

namespace AirlineReservationSystem
{
  public class Airline : IAirline
  {
    public string Name;
    private List<Flight> _flights;

    public Airline(string name)
    {
      Name = name;
      _flights = new List<Flight>();
    }

    public Ticket BookTicket(string flightId, Guid id)
    {
      var flight = _flights.SingleOrDefault(f => f.Id == flightId);
      if (flight.GetTicketAvailable() == 0)
      {
        return null;
      }

      var ticket = flight.BookTicket(id);
      return ticket;
    }

    public bool Cancel(string flightId, int ticketId)
    {
      var ticket = _flights.SingleOrDefault(f => f.Id == flightId).GetTicketById(ticketId);
      ticket.Canceled();
      return true;
    }

    public void CreateFlight(string flightId)
    {
      _flights.Add(new Flight(flightId));
    }

    public void ShowAllFlights()
    {
      foreach (var flight in _flights)
      {
        flight.Show();
      }
    }
  }
}
