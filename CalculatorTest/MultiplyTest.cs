using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorTest
{
    public class MultiplyTest
    {
        [Fact]
        public void Multiply_ShouldWorkWithTwoNumbers()
        {
            double result = Calculator.Calculator.Multiply(new double[] {5,2});
            Assert.Equal(10, result);
        }

        [Fact]
        public void Multiply_ShouldWorkWithMoreThanTwoNumbers()
        {
            double result = Calculator.Calculator.Multiply(new double[] { 1, 2, 3, 4 });
            Assert.Equal(24, result);
        }

        [Fact]
        public void Multiply_ShouldReturnZeroIfInputHasZeroItems()
        {
            double result = Calculator.Calculator.Multiply(new double[] {});
            Assert.Equal(0, result);
        }

    }
}
