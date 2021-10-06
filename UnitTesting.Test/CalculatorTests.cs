using NUnit.Framework;

namespace UnitTesting.Test
{
  [TestFixture]
  class CalculatorTests
  {
    [Test]
    public void Add_WhenCalled_ReturnTheSumOfArguments()
    {
      // AAA
      // Arrange
      Calculator cal = new Calculator();


      // Act
      var actualResult = cal.Add(1, 2);
      var expectedResult = 3;

      // Assert
      Assert.AreEqual(expectedResult, actualResult);
    }
  }
}
