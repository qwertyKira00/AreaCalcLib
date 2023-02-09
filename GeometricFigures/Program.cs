using AreaCalc;
using AreaCalc.Figures;

namespace Program;

class Program
{
    static async Task Main(string[] args)
    {
        var areaCalculator = new AreaCalculator();
        var t = new Triangle(4, 9, 10);
        var c = new Circle(200);
       
        // Triangle area
        Console.WriteLine(areaCalculator.CalcGeometricFigureArea(t));
        // Check if triangle is right-angled
        Console.WriteLine(t.IsRightAngled());

        // Circle area
        Console.WriteLine(areaCalculator.CalcGeometricFigureArea(c));
    }
}
