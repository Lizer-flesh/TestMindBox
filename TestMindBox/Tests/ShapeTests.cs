using TestMindBox.Figures;
using Xunit;

namespace TestMindBox.Tests;


public class ShapeTests
{
    [Fact]
    public void Circle_CalculatingArea_ReturnsCorrectValue()
    {
        var circle = new Circle(5);
        var area = AreaCalculator.CalculateArea(circle);
        
        Assert.Equal(Math.PI * 25, area);
    }

    [Fact]
    public void Square()
    {
        var triangle = new Triangle(8, 6, 5);
        var isValid = 15;
        var result = triangle.CalculatingArea();
        Assert.Equal(isValid, result);
    }

    [Fact]
    public void Triangle_IsRightAngledTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        var result = triangle.IsRightAngledTriangle();
        Assert.True(result);
    }
}