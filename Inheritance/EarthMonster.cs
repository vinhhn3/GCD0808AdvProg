namespace Inheritance
{
  class EarthMonster : Monster
  {
    public int Mana;

    public EarthMonster()
    {

    }

    public EarthMonster(string fullName, int hp, int defense, int mana)
    {
      FullName = fullName;
      HP = hp;
      Defense = defense;
      Mana = mana;
    }
  }
}
