using System;

namespace FactoryPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var woodenDoor = DoorFactory.MakeWoodenDoor(10, 20);

      var glassDoor = DoorFactory.MakeGlassDoor(20, 30);

      var steelDoor = DoorFactory.MakeSteelDoor(30, 40);

      Console.WriteLine($"Height: {steelDoor.GetHeight()} |" +
        $"Width: {steelDoor.GetWidth()} | Material: {steelDoor.GetMaterial()}");

      Console.ReadLine();
    }
  }
}
