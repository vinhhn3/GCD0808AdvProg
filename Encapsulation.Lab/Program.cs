using System;

namespace Encapsulation.Lab
{
  class Program
  {
    static void Main(string[] args)
    {
      Team team = new Team("A-Team");
      team.AddPlayer(new Person("John", "Lennon", 50, 1000));
      team.AddPlayer(new Person("Paul", "Vic", 35, 2000));
      team.AddPlayer(new Person("George", "Winston", 39, 1000));
      team.AddPlayer(new Person("James", "Bond", 60, 2000));
      team.AddPlayer(new Person("Axl", "Rose", 23, 1000));

      team.PrintInfo();

      Console.ReadLine();

    }
  }
}
