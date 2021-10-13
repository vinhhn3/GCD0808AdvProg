namespace BuilderPattern
{
  class Shop
  {
    public void Construct(VehiculeBuilder builder)
    {
      builder.BuildEngine();
      builder.BuildDoors();
      builder.BuildFrame();
      builder.BuildWheels();
    }
  }
}
