using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorTest
{
    public class AddTest
    {
        [Fact]
        public void Add_ShouldWorkWithTwoNumbers()
        {
            double result = Calculator.Calculator.Add(new double[] {2,5});
            Assert.Equal(7, result);
        }

        [Fact]
        public void Add_ShouldWorkWithMoreThanTwoNumbers()
        {
            double result = Calculator.Calculator.Add(new double[] { 1, 2, 3, 4  });
            Assert.Equal(10, result);
        }

        [Fact]
        public void Add_ShouldReturnZeroIfInputHasZeroItems()
        {
            double result = Calculator.Calculator.Add(new double[] {});
            Assert.Equal(0, result);
        }

    }
}
