using System;

namespace BuilderPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      VehiculeBuilder vehiculeBuilder;

      Shop shop = new Shop();

      // Build Car
      vehiculeBuilder = new CarBuilder();
      shop.Construct(vehiculeBuilder);
      vehiculeBuilder.Vehicule().Show(); // car object

      // Build Scooter
      vehiculeBuilder = new ScooterBuilder();
      shop.Construct(vehiculeBuilder);
      vehiculeBuilder.Vehicule().Show();  // scooter object

      // Build Tesla
      vehiculeBuilder = new TeslaBuilder();
      shop.Construct(vehiculeBuilder);
      vehiculeBuilder.Vehicule().Show();  // Tesla object

      Console.ReadLine();
    }
  }
}
