using NUnit.Framework;
using System.Linq;

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

    [Test]
    public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbers()
    {
      // Arrange

      // Act
      var actualResult = _cal.GetOddNumbers(5);

      // Assert
      Assert.That(actualResult, Is.Not.Empty);
      Assert.AreEqual(actualResult.Count(), 3);
      Assert.AreEqual(actualResult, new[] { 1, 3, 5 });
    }

    [Test]
    public void GetOddNumbers_LimitIsEqualZero_ReturnEmptyArray()
    {
      // Arrange

      // Act
      var result = _cal.GetOddNumbers(0);

      // Assert
      Assert.That(result, Is.Empty);
      Assert.AreEqual(result.Count(), 0);
    }
  }
}
