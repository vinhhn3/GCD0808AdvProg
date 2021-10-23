using System;

namespace AirlineReservationSystem
{
  public interface IAirline
  {
    void ShowAllFlights();
    Ticket BookTicket(string flightId, Guid id);
    bool Cancel(string flightId, int ticketId);
  }
}
