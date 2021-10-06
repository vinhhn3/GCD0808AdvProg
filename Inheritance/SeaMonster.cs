namespace Inheritance
{
  class SeaMonster : Monster
  {
    public string Color;

    public SeaMonster() : base() { }

    public SeaMonster(string fullName, int hp, int defense)
      : base(fullName, hp, defense) { }

    public SeaMonster(string fullName, int hp, int defense, string color)
      : base(fullName, hp, defense)
    {
      Color = color;
    }

    public override void SelfHealing()
    {
      HP = HP + 200;
    }
  }
}
