namespace CommandPattern
{
  class TurnOff : ICommand
  {
    private Bulb _bulb;
    public TurnOff(Bulb bulb)
    {
      _bulb = bulb;
    }
    public void Execute()
    {
      _bulb.TurnOff();
    }

    public void Redo()
    {
      _bulb.TurnOff();
    }

    public void Undo()
    {
      _bulb.TurnOn();
    }
  }
}
