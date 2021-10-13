using System;

namespace AdapterPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      Hunter hunter = new Hunter();
      AfrianLion afrianLion = new AfrianLion();
      AsianLion asianLion = new AsianLion();

      hunter.Hunt(asianLion);
      hunter.Hunt(afrianLion);

      WildDog wildDog = new WildDog();
      DogAdapter dogAdapter = new DogAdapter(wildDog);
      hunter.Hunt(dogAdapter);

      Console.ReadLine();
    }
  }
}
