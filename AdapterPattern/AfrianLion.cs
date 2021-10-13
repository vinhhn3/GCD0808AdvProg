using System;

namespace AdapterPattern
{
  class AfrianLion : ILion
  {
    public void Roar()
    {
      Console.WriteLine("African Lion roars");
    }
  }

}
