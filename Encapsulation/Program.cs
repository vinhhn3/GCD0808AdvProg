﻿using System;

namespace Encapsulation
{
  class Program
  {
    static void Main(string[] args)
    {
      Hero hero = new Hero("Paladin", 100, 100, 100);
      Monster monster = new Monster("Diablo", 1000, 1000, "Chaos Sanctuary", "Fire");
      monster.PrintInfo();

      hero.Attack(monster);
      monster.PrintInfo();

      Console.WriteLine(monster.GetLocation());
      Console.WriteLine(monster.Location);

      //monster.Location = "Heaven";
      //monster.Location = "123";
      //monster.Skill = "Cold";

      Console.ReadLine();


    }
  }
}
