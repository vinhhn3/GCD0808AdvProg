using NUnit.Framework;

namespace UnitTesting.Test
{
  [TestFixture]
  class CalculatorTests
  {
    private Calculator _cal;
    // Set Up
    [SetUp]
    public void SetUp()
    {
      _cal = new Calculator();
    }

    [Test]
    public void Add_WhenCalled_ReturnTheSumOfArguments()
    {
      // AAA
      // Arrange


      // Act
      var actualResult = _cal.Add(1, 2);
      var expectedResult = 3;

      // Assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    [TestCase(2, 2, 2)]
    [TestCase(2, 1, 2)]
    [TestCase(1, 2, 2)]
    public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
    {
      // Arrange

      // Act 
      var actualResult = _cal.Max(a, b);

      // Assert
      Assert.AreEqual(expectedResult, actualResult);
    }
  }
}
