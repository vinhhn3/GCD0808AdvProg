using System;

namespace Encapsulation
{
  class Monster
  {
    private string FullName;
    private int HP;
    private int Defense;
    public string Location { get; private set; }


    public Monster()
    {
      FullName = "N/A";
      HP = -1;
      Defense = -1;
      Location = "N/A";
    }

    public Monster(string fullName, int hp, int defense, string location)
    {
      FullName = fullName;
      HP = hp;
      Defense = defense;
      Location = location;
    }
    public void PrintInfo()
    {
      Console.WriteLine($"Name: {FullName} | HP: {HP} " +
        $"| Defense: {Defense} | Location: { Location}");
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

    public string GetLocation()
    {
      return Location;
    }
  }
}
