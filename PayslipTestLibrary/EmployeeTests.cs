using Generator;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PayslipTestLibrary
{
    public class EmployeeTests
    {
        [Fact]
        public void GivenEmployeeCSV_ReturnsNewEmployee()
        {
            var emp = "David,Rudd,60050,9 %,01 March – 31 March";

            NZTaxCalculator nzTaxCalculator = new NZTaxCalculator();
            Employee employee = new Employee();
            employee.GetEmployee( emp);

            Assert.Equal( "David" , employee.FirstName );
            Assert.Equal( "Rudd" , employee.LastName );
            Assert.Equal( 60050m , employee.Salary );
            Assert.Equal( 0.09m , employee.SuperRate );
            Assert.Equal( "01 March – 31 March" , employee.PayPeriod );
        }

        [Fact]
        public void GivenEmployee_ReturnsNewEmployeeCalculations ()
        {
            var employee = new Employee()
            {
                FirstName = "John",
                LastName = "Smith",
                Salary = 60050m,
                SuperRate = 0.09m,
                PayPeriod = "01 March – 31 March"
            };

            NZTaxCalculator nzTaxCalculator = new NZTaxCalculator();

            employee.GetEmployeeTaxInformation( nzTaxCalculator);

            Assert.Equal( 5004m, employee.MonthlyGrossIncome );
            Assert.Equal(11063m , employee.YearlyIncomeTax );
            Assert.Equal(  4082m, employee.MonthlyNetIncome );
            Assert.Equal( 450m, employee.SuperAmount );
        }
    }
}
