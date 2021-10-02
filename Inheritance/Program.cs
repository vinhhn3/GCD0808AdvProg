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

      Monster monster = new Monster(fullName: "Andarial", hp: 400, defense: 100);
      SeaMonster seaMonster = new SeaMonster(
        fullName: "Duriel", hp: 500, defense: 150, color: "Black");

      Hero paladin = new Hero("Paladin", 200, 100, 250);

      paladin.Attack(monster);
      paladin.Attack(earthMonster_1);
      paladin.Attack(seaMonster);



      Console.ReadLine();

    }
  }
}
