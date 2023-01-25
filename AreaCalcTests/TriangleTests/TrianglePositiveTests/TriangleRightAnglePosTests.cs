using AreaCalc;
using AreaCalc.Figures;

namespace AreaCalcTests.TriangleTests;

public class TriangleRightAngleTests
{
    public TriangleRightAngleTests()
    { 
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    public void TriangleRightAngleTest(double side1, double side2, double side3, bool expected)
    {
        var triangle = new Triangle(side1, side2, side3);

        var actual = triangle.IsRightAngled();
        Assert.Equal(expected, actual);
    }
}

