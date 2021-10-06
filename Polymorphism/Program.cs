using System;

namespace Polymorphism
{
  class Program
  {
    static void Main(string[] args)
    {
      Monster monster = new Monster("Lich King");

      monster.Attack(); // void
      monster.Attack("Super Nova"); // void
      Console.WriteLine(monster.Attack("Lighitng Fury", 10)); // string

      SuperSaiyan saiyan = new SuperSaiyan("Songoku", 1000, 100);
      saiyan.Attack();

      Console.ReadLine();
    }
  }
}
