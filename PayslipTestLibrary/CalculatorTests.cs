using Generator;
using System;
using Xunit;

namespace PayslipTestLibrary
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData( 50000 , 4167 )]
        [InlineData( 60000 , 5000 )]
        [InlineData( 1 , 0 )]
        [InlineData( -2000 , 0 )]
        public void GivenCalculator_WhenYearlySalaryEntered_ReturnsGrossIncomeForMonth ( decimal yearlySalary , decimal monthlyIncome )
        {
            var calculator = new NZTaxCalculator();

            var actual = calculator.CalculateMonthlyGrossIncome(yearlySalary);

            Assert.Equal( monthlyIncome , actual );
        }

        [Theory]
        [InlineData(18000,0)]
        [InlineData(20000,342)]
        [InlineData(80000,17547)]
        public void GivenCaclulator_WhenGivenSalary_ReturnIncomeTaxAmount(decimal income, decimal tax)
        {
            var calculator = new NZTaxCalculator();

            var actual = calculator.CalculateIncomeTax( income );

            Assert.Equal( tax , actual );
        }

        [Fact]
        public void GivenCaclulator_WhenGivenIncomeAndTax_ReturnNetIncomeTotal ()
        {
            var calculator = new NZTaxCalculator();

            var actual = calculator.CalculateMonthlyNetIncome( 5004,11063 );

            Assert.Equal( 4082m , actual );
        }
    }
}
