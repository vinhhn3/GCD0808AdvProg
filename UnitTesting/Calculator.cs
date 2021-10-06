namespace UnitTesting
{
  public class Calculator
  {
    public int Add(int a, int b)
    {
      return a + b;
    }

    public int Substract(int a, int b)
    {
      return a - b;
    }

    public int Multiply(int a, int b)
    {
      return a * b;
    }

    public int Max(int a, int b)
    {
      return (a > b) ? a : b;
    }
  }
}
