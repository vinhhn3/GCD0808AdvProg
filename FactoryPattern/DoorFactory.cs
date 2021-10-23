namespace FactoryPattern
{
  class DoorFactory
  {
    public static Door MakeWoodenDoor(int height, int width)
    {
      return new WoodenDoor(height, width);
    }

    public static Door MakeGlassDoor(int height, int width)
    {
      return new GlassDoor(height, width);
    }

    public static Door MakeSteelDoor(int height, int width)
    {
      return new SteelDoor(height, width);
    }
  }
}
