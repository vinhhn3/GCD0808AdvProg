namespace CommandPattern
{
  interface ICommand
  {
    void Execute();
    void Undo();
    void Redo();
  }
}
