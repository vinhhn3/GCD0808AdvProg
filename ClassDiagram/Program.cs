namespace ClassDiagram
{
  class Program
  {
    static void Main(string[] args)
    {
      Hero hero = new Hero();
      Monster monster = new Monster();

      hero.Attack(monster);
      monster.Attack(hero);
    }
  }
}
