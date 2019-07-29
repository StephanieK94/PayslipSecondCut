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
        [InlineData(20000,28)]
        [InlineData(80000,1462)]
        public void GivenCalculator_WhenGivenSalary_ReturnIncomeTaxAmount(decimal income, decimal tax)
        {
            var calculator = new NZTaxCalculator();

            var actual = calculator.CalculateMonthlyIncomeTax( income );

            Assert.Equal( tax , actual );
        }

        [Fact]
        public void GivenCalculator_WhenGivenIncomeAndTax_ReturnNetIncomeTotal ()
        {
            var calculator = new NZTaxCalculator();

            var actual = calculator.CalculateMonthlyNetIncome( 5004,922 );

            Assert.Equal( 4082m , actual );
        }

        [Fact]
        public void GivenCalculator_WhenGivenMonthlyIncome_ReturnSuperTaxTotal ()
        {
            var calculator = new NZTaxCalculator();

            var actual = calculator.CalculateSuperTax( 5004m , 0.09m);

            Assert.Equal( 450m , actual );
        }
    }
}
