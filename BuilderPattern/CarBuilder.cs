namespace BuilderPattern
{
  class CarBuilder : VehiculeBuilder
  {
    public CarBuilder()
    {
      vehicule = new Vehicule("car");
    }
    public override void BuildDoors()
    {
      vehicule["doors"] = "4 doors";
    }

    public override void BuildEngine()
    {
      vehicule["engine"] = "BWM engine";
    }

    public override void BuildFrame()
    {
      vehicule["frame"] = "car steel frame";
    }

    public override void BuildWheels()
    {
      vehicule["wheels"] = "4 car wheels";
    }
  }
}
