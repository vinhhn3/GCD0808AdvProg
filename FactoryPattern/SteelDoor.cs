namespace FactoryPattern
{
  class SteelDoor : Door
  {
    public SteelDoor(int height, int width)
    {
      _height = height;
      _width = width;
      _material = "steel";
    }
  }
}
