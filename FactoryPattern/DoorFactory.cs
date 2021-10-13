namespace FactoryPattern
{
  class DoorFactory
  {
    public static WoodenDoor MakeWoodenDoor(int height, int width)
    {
      return new WoodenDoor(height, width);
    }

    public static GlassDoor MakeGlassDoor(int height, int width)
    {
      return new GlassDoor(height, width);
    }

    public static SteelDoor MakeSteelDoor(int height, int width)
    {
      return new SteelDoor(height, width);
    }
  }
}
