using AreaCalc;
using AreaCalc.Figures;

namespace AreaCalcTests.TriangleTests.TriangleNegativeTests
{
	public class TriangleInvalidArgsNegTests
	{
		public TriangleInvalidArgsNegTests()
		{
		}

		[Theory]
		[InlineData(0, 2, 10)]
		[InlineData(2, -2, 4)]
        [InlineData(5, 9, 0)]
        [InlineData(0, 0, 0)]
        public void InvalidSidesTest(double side1, double side2, double side3)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(side1, side2, side3));
		}

		[Theory]
		[InlineData(1, 1, 2)]
        [InlineData(50, 15, 11)]
        [InlineData(1, 10, 6)]
        public void InvalidTriangleTest(double side1, double side2, double side3)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(side1, side2, side3));
		}
	}
}

