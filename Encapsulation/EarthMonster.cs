using System;

namespace Encapsulation
{
  class EarthMonster : Monster
  {
    private int Mana;

    public EarthMonster(string fullName, int hp, int defense, string location, string skill, int mana)
      : base(fullName, hp, defense, location, skill)
    {
      Mana = mana;
    }

    public void PrintSkill()
    {
      Console.WriteLine(Skill);
    }

    public void SetLocation()
    {
      Location = "Earth-512";
    }
  }
}
