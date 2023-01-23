namespace AreaCalc;

public abstract class GeometricFigure
{
    // Method for getting figure's area
    public abstract double CalculateArea();

}

public class Triangle : GeometricFigure
{
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    double _firstSide;
    public double FirstSide
    {
        get => _firstSide;
        set { _firstSide = value; }
    }

    double _secondSide;
    public double SecondSide
    {
        get => _secondSide;
        set { _secondSide = value; }
    }

    double _thirdSide;
    public double ThirdSide
    {
        get => _thirdSide;
        set { _thirdSide = value; }
    }

    public override double CalculateArea()
    {
        var semiPerimeter = CalculateSemiPerimeter();
        return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) *
            (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
    }

    public bool isRightAngleTriangle()
    { 
        var hypotenuse = (FirstSide >= SecondSide && FirstSide >= ThirdSide) ? FirstSide :
            (SecondSide >= FirstSide && SecondSide >= ThirdSide) ? SecondSide : ThirdSide;
        var cathetus1 = FirstSide != hypotenuse ? FirstSide : SecondSide;
        var cathetus2 = (FirstSide != hypotenuse && FirstSide != cathetus1) ? FirstSide :
            (SecondSide != hypotenuse && SecondSide != cathetus1) ? SecondSide : ThirdSide;

        return hypotenuse * hypotenuse == cathetus1 * cathetus1 + cathetus2 * cathetus2;
    }

    private double CalculateSemiPerimeter() => (FirstSide + SecondSide + ThirdSide) / 2;
}

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