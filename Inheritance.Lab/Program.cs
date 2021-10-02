using System;

namespace Inheritance.Lab
{
  class Program
  {
    static void Main(string[] args)
    {
      Animal animal = new Animal();
      Dog dog = new Dog();
      dog.Bark();
      dog.Bark();
      dog.Eat();

      animal.Eat();

      Console.ReadLine();


    }
  }
}
