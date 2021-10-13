namespace FactoryPattern
{
  abstract class Door
  {
    protected int _height;
    protected int _width;
    protected string _material;

    public string GetMaterial()
    {
      return _material;
    }
    public int GetHeight()
    {
      return _height;
    }
    public int GetWidth()
    {
      return _width;
    }
  }
}
