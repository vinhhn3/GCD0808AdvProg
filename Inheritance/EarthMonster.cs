namespace Inheritance
{
  class EarthMonster : Monster
  {
    public int Mana;

    public EarthMonster() : base()
    {

    }


    //public Monster(string fullName, int hp, int defense)
    //{
    //  FullName = fullName;
    //  HP = hp;
    //  Defense = defense;
    //}

    public EarthMonster(string fullName)
      : base(fullName, 0, 0)
    {
      Mana = 0;
    }

    public EarthMonster(string fullName, int hp, int defense)
      : base(fullName, hp, defense)
    {

    }

    public EarthMonster(string fullName, int hp, int defense, int mana)
      : base(fullName, hp, defense)
    {
      Mana = mana;
    }

    public override void SelfHealing()
    {
      HP = HP + 100;
    }
  }
}
