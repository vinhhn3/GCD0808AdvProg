using System;

namespace AirlineReservationSystem
{
  public class Ticket
  {
    public int Id;
    public bool IsAvailable;
    public Guid? UserId;

    public Ticket(int id)
    {
      Id = id;
      IsAvailable = true;
      UserId = null;
    }

    public void Canceled()
    {
      IsAvailable = true;
      UserId = null;
    }

    public void Book(Guid userId)
    {
      IsAvailable = false;
      UserId = userId;
    }
  }
}
