using System;

namespace Polymorphism
{
  class SuperSaiyan : Monster
  {
    public int Mana;

    public SuperSaiyan(string fullName, int attackPoint, int mana)
      : base(fullName, attackPoint)
    {
      Mana = mana;
    }

    public override void Attack()
    {
      //base.Attack();
      Console.WriteLine("SuperSaiyan using 10 Mana Point");
      Mana = Mana - 10;
      Console.WriteLine("Current Mana pool: " + Mana);
    }
  }
}
