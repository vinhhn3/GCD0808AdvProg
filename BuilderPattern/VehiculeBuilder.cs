namespace BuilderPattern
{
  abstract class VehiculeBuilder
  {
    protected Vehicule vehicule;
    public Vehicule Vehicule()
    {
      return vehicule;
    }

    // abstract builder methods
    public abstract void BuildFrame();
    public abstract void BuildDoors();
    public abstract void BuildWheels();
    public abstract void BuildEngine();
  }
}
