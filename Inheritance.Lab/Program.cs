using System;

namespace Inheritance.Lab
{
  class Program
  {
    static void Main(string[] args)
    {
      Animal animal = new Animal();
      Dog dog = new Dog();
      Puppy puppy = new Puppy();
      Cat cat = new Cat();
      dog.Bark();
      dog.Bark();
      dog.Eat();

      animal.Eat();

      puppy.Eat();
      puppy.Bark();
      puppy.Weep();

      cat.Eat();
      cat.Meow();

      RandomList list = new RandomList();
      list.Add("Diablo");
      list.Add("Baal");
      list.Add("Andariel");
      list.Add("Melphisto");
      list.Add("Duriel");

      Console.WriteLine(list.RandomString());

      Console.ReadLine();

    }
  }
}
