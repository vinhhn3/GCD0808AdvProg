namespace AdapterPattern
{
  class DogAdapter : ILion
  {
    private WildDog _wildDog;
    public DogAdapter(WildDog wildDog)
    {
      _wildDog = wildDog;
    }
    public void Roar()
    {
      _wildDog.Roar();
    }
  }
}
