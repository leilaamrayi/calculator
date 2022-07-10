using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorTest
{
    public class ParseInputTest
    {
        [Fact]
        public void ParseInputToNumbers_ShouldReturnCorrectValues()
        {
            double[] result = Calculator.Calculator.ParseInputToNumbers("1 2 3 4");
            Assert.Equal(new double[] { 1, 2, 3, 4 }, result);
        }

        [Fact]
        public void ParseInputToNumbers_ShouldReturnEmptyArrayIfInputIsNull()
        {
            double[] result = Calculator.Calculator.ParseInputToNumbers(null);
            Assert.Equal(new double[0], result);
        }

        [Fact]
        public void ParseInputToNumbers_ShouldReturnEmptyArrayIfInputIsAnEmptyString()
        {
            double[] result = Calculator.Calculator.ParseInputToNumbers("");
            Assert.Equal(new double[0], result);
        }

        [Fact]
        public void ParseInputToNumbers_ShouldIgnoreInvalidCharacters()
        {
            double[] result = Calculator.Calculator.ParseInputToNumbers(" 1 2 u 4 (  ");
            Assert.Equal(new double[] { 1, 2, 4 }, result);
        }

        [Fact]
        public void InputIsValidForDivide_ShouldReturnFalseIfInputContainsZero()
        {
            bool result = Calculator.Calculator.InputIsValidForDivide(new double[] { 1, 0, 3, 4 });
            Assert.False(result);
        }

    }
}
