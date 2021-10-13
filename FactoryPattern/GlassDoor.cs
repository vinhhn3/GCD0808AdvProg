namespace FactoryPattern
{
  class GlassDoor : Door
  {
    public GlassDoor(int height, int width)
    {
      _height = height;
      _width = width;
      _material = "glass";
    }
  }
}
