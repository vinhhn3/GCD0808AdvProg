namespace ClassDiagram
{
  class Player
  {
    void Use(ICharacter character)
    {
      character.Jump();
      character.Walk();
    }
  }
}
