using AreaCalc;

namespace Program;

class Program
{
   
    static async Task Main(string[] args)
    {
        var areaCalculator = new AreaCalculator();
        var t = new Triangle(2.1, 3.5, 2.8);
        var c = new Circle(10);
       
        // Triangle area
        Console.WriteLine(areaCalculator.CalcGeometricFigureArea(t));
        // Check if triangle is right angle triangle
        Console.WriteLine(t.isRightAngleTriangle());

        // Circle area
        Console.WriteLine(areaCalculator.CalcGeometricFigureArea(c));
    }
}
