using System;

namespace Encapsulation
{
  class Monster
  {
    private string FullName;
    private int HP;
    private int Defense;

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

    public string GetFullName()
    {
      return FullName;
    }

    public int GetHP()
    {
      return HP;
    }

    public int GetDefense()
    {
      return Defense;
    }

    public void DecreaseHP(int hp)
    {
      HP = HP - hp;
    }
  }
}
