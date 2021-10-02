using System;

namespace Encapsulation
{
  class Monster
  {
    private string FullName;
    private int HP;
    private int Defense;
    public string Location { get; protected set; }
    protected string Skill;

    public Monster(string fullName, int hP, int defense, string location, string skill)
    {
      FullName = fullName;
      HP = hP;
      Defense = defense;
      Location = location;
      Skill = skill;
    }

    public Monster()
    {
      FullName = "N/A";
      HP = -1;
      Defense = -1;
      Location = "N/A";
      Skill = "N/A";
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
