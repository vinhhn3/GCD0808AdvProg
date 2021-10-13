namespace CommandPattern
{
  class TurnOn : ICommand
  {
    private Bulb _bulb;
    public TurnOn(Bulb bulb)
    {
      _bulb = bulb;
    }
    public void Execute()
    {
      _bulb.TurnOn();
    }

    public void Redo()
    {
      _bulb.TurnOn();
    }

    public void Undo()
    {
      _bulb.TurnOff();
    }
  }
}
