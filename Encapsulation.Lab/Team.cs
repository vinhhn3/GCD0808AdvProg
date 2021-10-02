using System;
using System.Collections.Generic;

namespace Encapsulation.Lab
{
  class Team
  {
    private string _name;
    private List<Person> _firstTeam;
    private List<Person> _reserveTeam;
    public IReadOnlyList<Person> FirstTeam
    {
      get
      {
        return _firstTeam.AsReadOnly();
      }
    }
    public IReadOnlyList<Person> ReserveTeam
    {
      get
      {
        return _reserveTeam.AsReadOnly();
      }
    }

    public Team(string name)
    {
      _name = name;
      _firstTeam = new List<Person>();
      _reserveTeam = new List<Person>();
    }

    public void AddPlayer(Person person)
    {
      if (person.Age < 40)
      {
        _firstTeam.Add(person);
      }
      else
      {
        _reserveTeam.Add(person);
      }
    }

    public void PrintInfo()
    {
      Console.WriteLine($"Team name: {_name}");
      Console.WriteLine("FIRST TEAM");
      Console.WriteLine("Number of players: " + _firstTeam.Count);
      foreach (var player in _firstTeam)
      {
        Console.WriteLine($"{player.FirstName} {player.LastName} | Age: {player.Age}");
      }

      Console.WriteLine("RESERVE TEAM");
      Console.WriteLine("Number of players: " + _reserveTeam.Count);
      foreach (var player in _reserveTeam)
      {
        Console.WriteLine($"{player.FirstName} {player.LastName} | Age: {player.Age}");
      }
    }
  }
}
