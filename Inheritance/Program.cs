using System;

namespace Inheritance
{

  class Program
  {
    static void Main(string[] args)
    {
      EarthMonster earthMonster_1 = new EarthMonster();
      EarthMonster earthMonster_2 = new EarthMonster(
        fullName: "Diablo",
        hp: 123,
        defense: 100,
        mana: 123
        );

      earthMonster_1.FullName = "Baal";
      earthMonster_1.Defense = 123;
      earthMonster_1.HP = 999;

      earthMonster_1.PrintInfo();
      earthMonster_2.PrintInfo();

      // Because class Monster is an abstract class, 
      // we can't create object Monster
      //Monster monster = new Monster(fullName: "Andarial", hp: 400, defense: 100);
      SeaMonster seaMonster = new SeaMonster(
        fullName: "Duriel", hp: 500, defense: 150, color: "Black");

      Hero paladin = new Hero("Paladin", 200, 100, 250);

      //paladin.Attack(monster);
      paladin.Attack(earthMonster_1);
      paladin.Attack(seaMonster);

      // Parent class can be init as Child class
      Monster monster_2 = new EarthMonster();
      Monster monster_3 = new EarthMonster("Heriel", 100, 200, 300);
      Monster monster_4 = new SeaMonster();

      // Child class can't initialize as Parent class
      //EarthMonster earthMonster_3 = new Monster();
      Console.WriteLine("Before SelfHealing");
      earthMonster_1.PrintInfo();
      seaMonster.PrintInfo();

      Console.WriteLine("After SelfHealing");
      earthMonster_1.SelfHealing();
      seaMonster.SelfHealing();

      earthMonster_1.PrintInfo();
      seaMonster.PrintInfo();

      earthMonster_1.Die();
      paladin.Die();

      Player player = new Player("John");

      player.Control(paladin);
      player.Control(earthMonster_1);
      player.Control(seaMonster);

      Console.ReadLine();
    }
  }
}
