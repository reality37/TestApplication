using Xunit;
using CalculateSquareLibrary;

namespace CalculateSquareLibraryTests;

public class CalculateSquareLibraryTests
{
    /// <summary>
    /// Проверяет расчет площади круга
    /// </summary>
    [Fact]
    public void CalculateCircleAreaTest()
    {
        var circle = new Circle(5);
        var expectedSquare = Math.PI * 5 * 5;
        
        Assert.Equal(expectedSquare, circle.CalculateArea());
    }

    [Fact]
    public void CalculateTriangleSquareTest()
    {
        var triangle = new Triangle(4, 3, 5);
        
        var p = (4.0 + 3.0 + 5.0) / 2.0;

        var expectedSquare = Math.Sqrt(p * (p - 4.0) * (p - 3.0) * (p - 5.0));
        
        Assert.Equal(expectedSquare, triangle.CalculateArea());
    }

    [InlineData(4, 3, 5, true)]
    [InlineData(4, 3, 3, false)]
    [Theory]
    public void IsRectangleTest(double firstSide, double secondSide, double thirdSide, bool expectedResult)
    {
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        Assert.Equal(expectedResult, triangle.IsRectangle());
    }
}