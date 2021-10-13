using System;

namespace AdapterPattern
{
  class AsianLion : ILion
  {
    public void Roar()
    {
      Console.WriteLine("Asian Lion roars");
    }
  }

}
