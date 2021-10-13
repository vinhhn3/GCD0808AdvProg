namespace FactoryPattern
{
  class WoodenDoor : Door
  {
    public WoodenDoor(int height, int width)
    {
      _height = height;
      _width = width;
      _material = "wood";
    }
  }
}
