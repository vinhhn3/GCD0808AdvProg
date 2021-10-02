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

      Console.ReadLine();

    }
  }
}
