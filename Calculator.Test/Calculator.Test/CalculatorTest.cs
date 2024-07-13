using Xunit;
namespace Calculator.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            var num1 = 4;
            var num2 = 4;
            Assert.Equal(num1, num2);
            Assert.True(true);
        }
    }
}