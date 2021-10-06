using System;

namespace Inheritance
{
  class Player
  {
    string FullName;

    public Player(string fullName)
    {
      FullName = fullName;
    }

    public void Control(ICharacter character)
    {
      Console.WriteLine($"Player {FullName} is controlling ...");
      character.Attack();
      character.Jump();
      character.Die();
      character.Walk();
    }
  }
}
