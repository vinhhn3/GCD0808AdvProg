using System;

namespace Inheritance
{
  class Monster
  {
    public string FullName;
    public int HP;
    public int Defense;

    public Monster()
    {
      FullName = "N/A";
      HP = -1;
      Defense = -1;
    }

    public Monster(string fullName, int hp, int defense)
    {
      FullName = fullName;
      HP = hp;
      Defense = defense;
    }

    public void PrintInfo()
    {
      Console.WriteLine($"Name: {FullName} | HP: {HP} | Defense: {Defense}");
    }
  }
}
