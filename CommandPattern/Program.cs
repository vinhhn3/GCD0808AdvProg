using System;

namespace CommandPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      Bulb bulb = new Bulb();

      TurnOn turnOn = new TurnOn(bulb);
      TurnOff turnOff = new TurnOff(bulb);

      RemoteControl remoteControl = new RemoteControl();

      // Use TurnOn
      remoteControl.Use(turnOn);
      remoteControl.Undo(turnOn);
      remoteControl.Redo(turnOn);

      // Use TurnOff
      remoteControl.Use(turnOff);
      remoteControl.Undo(turnOff);
      remoteControl.Redo(turnOff);

      Console.ReadLine();

    }
  }
}

