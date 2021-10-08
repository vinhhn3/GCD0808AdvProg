namespace ClassDiagram
{
  class Program
  {
    static void Main(string[] args)
    {
      Hero hero = new Hero(100, 100, "Lich King");
      Monster monster = new Monster();

      hero.Attack(monster);
      monster.Attack(hero);

      Item sword = new Item("sword");
      hero.PickUp(sword);
    }
  }
}
