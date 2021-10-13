using System;
using System.Collections.Generic;

namespace BuilderPattern
{
  class Vehicule
  {
    private string _vehiculeType;
    private Dictionary<string, string> _parts;

    public Vehicule(string type)
    {
      _vehiculeType = type;
      _parts = new Dictionary<string, string>();
    }

    public string this[string key]
    {
      get { return _parts[key]; }
      set { _parts[key] = value; }
    }

    public void Show()
    {
      Console.WriteLine("=============");
      Console.WriteLine($"Vehicule type: {_vehiculeType}");
      Console.WriteLine($"Frame: {_parts["frame"]}");
      Console.WriteLine($"Doors: {_parts["doors"]}");
      Console.WriteLine($"Wheels: {_parts["wheels"]}");
      Console.WriteLine($"Engine: {_parts["engine"]}");

    }
  }
}
