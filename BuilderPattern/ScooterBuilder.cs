namespace BuilderPattern
{
  class ScooterBuilder : VehiculeBuilder
  {
    public ScooterBuilder()
    {
      vehicule = new Vehicule("scooter");
    }
    public override void BuildDoors()
    {
      vehicule["doors"] = "0 door";
    }

    public override void BuildEngine()
    {
      vehicule["engine"] = "Honda engine";
    }

    public override void BuildFrame()
    {
      vehicule["frame"] = "scooter steel frame";
    }

    public override void BuildWheels()
    {
      vehicule["wheels"] = "2 scooter wheels";
    }
  }
}
