using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorTest
{
    public class DivideTest
    {
        [Fact]
        public void Divide_ShouldWorkWithTwoNumbers()
        {
            double result = Calculator.Calculator.Divide(new double[] {10,2});
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ShouldWorkWithMoreThanTwoNumbers()
        {
            double result = Calculator.Calculator.Divide(new double[] { 100, 2, 5, 2 });
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ShouldReturnZeroIfInputHasZeroItems()
        {
            double result = Calculator.Calculator.Divide(new double[] {});
            Assert.Equal(0, result);
        }

    }
}
