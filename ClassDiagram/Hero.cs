namespace ClassDiagram
{
  class Hero : Character
  {
    public string FullName;
    public Item Item;
    public Skill Skill;

    public Hero(int hp, int attackPoint, string fullName)
      : base(hp, attackPoint)
    {
      FullName = fullName;
      Skill = new Skill("Super Nova");
    }

    public Hero() { }

    public void Attack(Monster monster)
    {

    }

    public void PickUp(Item item)
    {
      Item = item;
    }
  }
}
