using Generator;
using System;
using Xunit;

namespace PayslipTestLibrary
{
    public class CalculatorTests
    {
        [Fact]
        public void GivenCalculator_WhenSalaryEntered_ReturnsZero ()
        {
            var calculator = new TaxCalculator();

            var actual = calculator.CalculateGrossIncome( 0m );

            Assert.Equal( 0 , actual );
        }
    }
}
