using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorTest
{
    public class SubstractTest
    {
        [Fact]
        public void Substract_ShouldWorkWithTwoNumbers()
        {
            double result = Calculator.Calculator.Substract(new double[] {5,2});
            Assert.Equal(3, result);
        }

        [Fact]
        public void Substract_ShouldWorkWithMoreThanTwoNumbers()
        {
            double result = Calculator.Calculator.Substract(new double[] { 10, 1, 2, 3 });
            Assert.Equal(4, result);
        }

        [Fact]
        public void Substract_ShouldReturnZeroIfInputHasZeroItems()
        {
            double result = Calculator.Calculator.Substract(new double[] {});
            Assert.Equal(0, result);
        }

    }
}
