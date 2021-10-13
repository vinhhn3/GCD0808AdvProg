using System;

namespace AdapterPattern
{
  class Hunter
  {
    public void Hunt(ILion lion)
    {
      Console.WriteLine("Hunting ...");
      lion.Roar();
    }
  }
}
