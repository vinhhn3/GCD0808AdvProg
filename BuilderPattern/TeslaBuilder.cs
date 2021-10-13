namespace BuilderPattern
{
  class TeslaBuilder : VehiculeBuilder
  {
    public TeslaBuilder()
    {
      vehicule = new Vehicule("Tesla X Model");
    }

    public override void BuildDoors()
    {
      vehicule["doors"] = "Auto Doors Tesla";
    }

    public override void BuildEngine()
    {
      vehicule["engine"] = "Tesla Engine";
    }

    public override void BuildFrame()
    {
      vehicule["frame"] = "Tesla Frame";
    }

    public override void BuildWheels()
    {
      vehicule["wheels"] = "4 Tesla Wheels";
    }
  }
}
