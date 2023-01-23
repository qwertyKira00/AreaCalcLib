using AreaCalc.BaseEntity;

namespace AreaCalc.Figures;

public class Circle : GeometricFigure
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    double _radius;
    public double Radius
    {
        get => _radius;
        set { _radius = value; }
    }

    public override double CalculateArea() => Radius * Radius * Math.PI;

}
