using AreaCalc.BaseEntity;

namespace AreaCalc.Figures;

public class Circle : GeometricFigure
{
    public Circle(double radius)
    {
       if (radius > 0)
       {
            _radius = radius;
       }
       else
       {
            throw new ArgumentOutOfRangeException();
       }

    }

    private double _radius;
    public double Radius
    {
        get => _radius;
        set
        {
            if (value > 0)
            {
                _radius = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    public override double CalculateArea() => _radius * _radius * Math.PI;
}
