using AreaCalc;
using AreaCalc.BaseEntity;
using AreaCalc.Figures;

namespace AreaCalcTests;

public class AreaCalcTests
{
    public readonly GeometricFigure triangle1;
    public readonly Triangle triangle2;
    public readonly GeometricFigure circle;
    public readonly AreaCalculator areaCalculator;

    public AreaCalcTests()
    {
        triangle1 = InitializeGeomTriangle();
        triangle2 = InitializeTriangle();
        circle = InitializeGeomCircle();
        areaCalculator = new AreaCalculator();
    }

    #region SuccessTests

    [Fact]
    public void TriangleAreaTest()
    {
        //Expected
        var areaExpected = 6;

        //Actual
        var areaActual = areaCalculator.CalcGeometricFigureArea(triangle1);

        Assert.Equal(areaExpected, areaActual);
    }

    [Fact]
    public void TriangleRightAngleTest()
    {
        //Actual
        var isRightAngle = triangle2.isRightAngleTriangle();
        Assert.True(isRightAngle);
    }

    [Fact]
    public void CircleAreaTest()
    {
        //Expected
        var areaExpected = 100 * Math.PI;

        //Actual
        var areaActual = areaCalculator.CalcGeometricFigureArea(circle);

        Assert.Equal(areaExpected, areaActual);

    }

    #endregion

    #region Initialization

    private GeometricFigure InitializeGeomTriangle() => new Triangle(3, 4, 5);

    private Triangle InitializeTriangle() => new Triangle(3, 4, 5);

    private GeometricFigure InitializeGeomCircle() => new Circle(10);

    #endregion
}

