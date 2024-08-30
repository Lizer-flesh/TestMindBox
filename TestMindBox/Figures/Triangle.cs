using TestMindBox.Exceptions;
using TestMindBox.Interfaces;

namespace TestMindBox.Figures;

public class Triangle : ITriangle
{
    private readonly double firstSide;
    private readonly double secondSide;
    private readonly double thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new IncorrectSideSizeException("Sides must be greater than 0");
        }

        this.firstSide = firstSide;
        this.secondSide = secondSide;
        this.thirdSide = thirdSide;
    }

    public double CalculatingArea()
    {
        var s = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt(s * (s - firstSide) * (s - secondSide) * (s - thirdSide));
    }

    public bool IsRightAngledTriangle()
    {
        double[] sides = {firstSide, secondSide, thirdSide};
        Array.Sort(sides);

        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}