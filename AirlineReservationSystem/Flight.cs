using System;
using System.Linq;

namespace AirlineReservationSystem
{
  public class Flight
  {
    public string Id;
    public Ticket[] _tickets;


    public Flight(string id)
    {
      Id = id;
      _tickets = new Ticket[]
      {
        new Ticket(1),
        new Ticket(2),
        new Ticket(3),
        new Ticket(4),
        new Ticket(5),
      };
    }

    public Ticket BookTicket(Guid userId)
    {
      var ticket = _tickets.FirstOrDefault(t => t.IsAvailable);
      ticket.Book(userId);
      return ticket;
    }

    public void Cancel(int ticketId)
    {
      _tickets[ticketId].Canceled();
    }

    public int GetTicketAvailable()
    {
      return _tickets.Count(t => t.IsAvailable); ;
    }

    public void Show()
    {
      Console.WriteLine("=====================");
      Console.WriteLine("Flight Id: " + Id);
      Console.WriteLine("Ticket Available: " + GetTicketAvailable());
      foreach (var ticket in _tickets)
      {
        if (!ticket.IsAvailable)
        {
          Console.WriteLine("Ticket Id: " + ticket.Id + " | UserId: " + ticket.UserId.ToString());
        }
      }
    }

    public Ticket GetTicketById(int id)
    {
      return _tickets[id];
    }


  }
}
