using Generator;
using System;
using Xunit;

namespace PayslipTestLibrary
{
    public class CalculatorTests
    {
        [InlineData(50000, 4167)]
        [InlineData(60000, 5000)]
        [InlineData(1, 0)]
        [InlineData(-2000, 0)]
        public void GivenCalculator_WhenYearlySalaryEntered_ReturnsGrossIncomeForMonth (decimal yearlySalary , decimal monthlyIncome )
        {
            var calculator = new TaxCalculator();

            var actual = calculator.CalculateGrossIncome( yearlySalary );

            Assert.Equal( monthlyIncome , actual );
        }
    }
}
