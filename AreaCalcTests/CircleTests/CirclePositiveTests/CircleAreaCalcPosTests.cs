using AreaCalc;
using AreaCalc.BaseEntity;
using AreaCalc.Figures;

namespace AreaCalcTests.CircleTests.CirclePositiveTests
{
	public class CircleAreaCalcPosTests
	{
		private readonly AreaCalculator _areaCalculator;

		public CircleAreaCalcPosTests()
		{
			_areaCalculator = new AreaCalculator();
		}

		[Theory]
		[InlineData(10, 314.159)]
		[InlineData(15.5, 754.768)]
		[InlineData(0.25, 0.196)]
        [InlineData(200, 125663.706)]
        public void CircleAreaTest(double radius, double expected)
		{
			GeometricFigure circle = new Circle(radius);

			var actual = _areaCalculator.CalcGeometricFigureArea(circle);

			Assert.Equal(expected, actual, 1e-3);
		}
	}
}

