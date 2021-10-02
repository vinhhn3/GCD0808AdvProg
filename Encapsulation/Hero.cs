using System;
using System.Collections.Generic;

namespace Encapsulation
{
  class Hero
  {
    // Properties
    public string FullName;
    public int HP;
    public int Mana;
    public int AttackPoint;
    private int _level;
    public int Level
    {
      get { return _level; }
      set
      {
        if (value < 1)
        {
          Console.WriteLine("Cannot set lower than 1");
          _level = 1;
        }
        else
        {
          Console.WriteLine("Set Level DONE");
          _level = value;
        }
      }
    }
    public Dictionary<Item, int> Inventory;

    // Static Member => attribute of Class (not Object)
    public static int Quantity;

    // Constructor without parameters
    public Hero()
    {
      FullName = "N/A";
      HP = -1;
      Mana = -1;
      AttackPoint = -1;
      Level = 0;
      Quantity++;
      Inventory = new Dictionary<Item, int>();
    }

    // Constructor with parameters
    public Hero(string fullName, int hp, int mana, int attackPoint)
    {
      FullName = fullName;
      HP = hp;
      Mana = mana;
      AttackPoint = attackPoint;
      Level = 1;
      Quantity++;
      Inventory = new Dictionary<Item, int>();
    }


    // Functions
    public void Walk()
    {
      Console.WriteLine($"{FullName} is walking ...");
    }

    public void Attack()
    {
      Console.WriteLine($"{FullName} is attacking ...");
    }

    public void Jump()
    {
      Console.WriteLine($"{FullName} is jumping ...");
    }

    public void PrintInfo()
    {
      Console.WriteLine($"{FullName} | HP: {HP} | MANA: {Mana} | ATTK: {AttackPoint} | LVL: {Level}");
    }

    public void Attack(Monster monster)
    {
      //monster.FullName = "Name changed inside Attack function";
      //monster.Defense = 0;
      //monster.HP = 0;
      Console.WriteLine($"{FullName} is attacking {monster.GetFullName()}");
      var difference = AttackPoint - monster.GetDefense();
      if (difference <= 0)
      {
        Console.WriteLine("No Effect ...");
      }
      else
      {
        Console.WriteLine("Effected ...");
        monster.DecreaseHP(difference);
        Console.WriteLine($"Current HP of {monster.GetFullName()} is: {monster.GetHP()} ");
      }
    }

    // Static function
    public static void PrintHeroQuantities()
    {
      Console.WriteLine($"Hero quantities: {Quantity}");
    }

    public void PickUp(Item item)
    {
      if (!Inventory.ContainsKey(item))
      {
        Inventory[item] = 1;
      }
      else
      {
        Inventory[item]++;
      }
    }

    public void PrintInventory()
    {
      foreach (var item in Inventory)
      {
        Console.WriteLine($"{item.Key} | {item.Value}");
      }
    }
  }
}
