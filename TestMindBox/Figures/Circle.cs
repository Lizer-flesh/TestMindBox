using TestMindBox.Exceptions;
using TestMindBox.Interfaces;

namespace TestMindBox.Figures;

public class Circle : IShape
{
    private readonly double radius;

    public Circle(double radius)
    {
        if (radius <= 0 || radius == 0)
            throw new IncorrectRadiusException("Radius must be greater than 0");

        this.radius = radius;
    }

    public double CalculatingArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}