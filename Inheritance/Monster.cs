using System;

namespace Inheritance
{
  abstract class Monster : ICharacter
  {
    public string FullName;
    public int HP;
    public int Defense;

    public Monster()
    {
      FullName = "N/A";
      HP = -1;
      Defense = -1;
    }

    public Monster(string fullName, int hp, int defense)
    {
      FullName = fullName;
      HP = hp;
      Defense = defense;
    }

    public void Attack()
    {
      Console.WriteLine($"Monster {FullName} is attacking ...");
    }

    public void Die()
    {
      HP = 0;
      Console.WriteLine($"Monster {FullName} is dead ...");

    }

    public void Jump()
    {
      Console.WriteLine($"Monster {FullName} is jumping ...");

    }

    public void PrintInfo()
    {
      Console.WriteLine($"Name: {FullName} | HP: {HP} | Defense: {Defense}");
    }

    // Abstract function: declare the function only without implementation
    // Child classes will implement the function
    public abstract void SelfHealing();

    public void Walk()
    {
      Console.WriteLine($"Monster {FullName} is walking ...");
    }
  }
}
