using System;

namespace ClassDiagram
{
  class Character : ICharacter
  {
    public int HP;
    public int AttackPoint;

    public Character(int hP, int attackPoint)
    {
      HP = hP;
      AttackPoint = attackPoint;
    }

    public Character()
    {
    }

    public void Walk()
    {
      Console.WriteLine("Character is Walking ...");
    }

    public void Jump()
    {
      Console.WriteLine("Character is Jumping ...");
    }
  }
}
