using Xunit;
using static Calculation.Calculation;

namespace CalculationTest
{
    public class UnitTest1
    {
        [Fact]
        public void PositiveResult()
        {
            Assert.Equal(2, Minus(6, 4));
        }

        [Fact]
        public void NegativeResult()
        {
            Assert.Equal(-2, Minus(6, 8));
        }
    }
}
