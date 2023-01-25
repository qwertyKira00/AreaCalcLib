using AreaCalc;
using AreaCalc.Figures;

namespace AreaCalcTests.CircleTests.CircleNegativeTests
{
	public class CircleInvalidArgsNegTests
	{
		public CircleInvalidArgsNegTests()
		{
		}

		[Theory]
		[InlineData(0)]
        [InlineData(-1)]
        [InlineData(-0.5)]
        public void InvalidRadiusTest(double radius)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
		}
	}
}

