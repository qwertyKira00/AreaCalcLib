using AreaCalc.BaseEntity;

namespace AreaCalc;

public class AreaCalculator
{
    public AreaCalculator() {}

    public double CalcGeometricFigureArea(GeometricFigure figure) => figure.CalculateArea();
}
