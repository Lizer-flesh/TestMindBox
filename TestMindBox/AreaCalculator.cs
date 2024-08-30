using TestMindBox.Interfaces;

namespace TestMindBox;

public static class AreaCalculator
{
    public static double CalculateArea<T>(T shape) where T : IShape
    {
        return shape.CalculatingArea();
    }
}