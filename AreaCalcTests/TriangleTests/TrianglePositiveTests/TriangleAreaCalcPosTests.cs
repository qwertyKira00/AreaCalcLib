using AreaCalc;
using AreaCalc.BaseEntity;
using AreaCalc.Figures;

namespace AreaCalcTests.TriangleTests;

public class TriangleAreaCalcTests
{
    private readonly AreaCalculator _areaCalculator;

    public TriangleAreaCalcTests()
	{
        _areaCalculator = new AreaCalculator();
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(2.1, 3.5, 2, 1.867)]
    [InlineData(4, 9, 10, 17.984)]
    public void TriangleAreaTest(double firstSide, double secondSide, double thirdSide, double expected)
    {
        GeometricFigure triangle = new Triangle(firstSide, secondSide, thirdSide);

        var actual = _areaCalculator.CalcGeometricFigureArea(triangle);

        Assert.Equal(expected, actual, 1e-3);
    }
}

