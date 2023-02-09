using AreaCalc.BaseEntity;

namespace AreaCalc.Figures;

public class Triangle : GeometricFigure
{
    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;

        if (!IsValidTriangle())
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    private double _side1;
    public double Side1
    {
        get => _side1;
        set
        {
            if (value > 0)
            {
                _side1 = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    private double _side2;
    public double Side2
    {
        get => _side2;
        set
        {
            if (value > 0)
            {
                _side2 = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    private double _side3;
    public double Side3
    {
        get => _side3;
        set
        {
            if (value > 0)
            {
                _side3 = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    public override double CalculateArea()
    {
        var semiPerimeter = CalculateSemiPerimeter();
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) *
            (semiPerimeter - _side2) * (semiPerimeter - _side3));
    }

    public bool IsRightAngled()
    {
        var side1_squared = _side1 * _side1;
        var side2_squared = _side2 * _side2;
        var side3_squared = _side3 * _side3;

        return side1_squared == side2_squared + side3_squared ||
            side2_squared == side1_squared + side3_squared ||
            side3_squared == side1_squared + side2_squared;
    }

    private bool IsValidTriangle() => _side1 < _side2 + _side3 &&
        _side2 < _side1 + _side3 && _side3 < _side1 + _side2;


    private double CalculateSemiPerimeter() => (_side1 + _side2 + _side3) / 2;
}
