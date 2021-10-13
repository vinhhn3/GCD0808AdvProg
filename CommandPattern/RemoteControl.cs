namespace CommandPattern
{
  class RemoteControl
  {
    public void Use(ICommand command)
    {
      command.Execute();
    }
    public void Redo(ICommand command)
    {
      command.Redo();
    }
    public void Undo(ICommand command)
    {
      command.Undo();
    }
  }
}
