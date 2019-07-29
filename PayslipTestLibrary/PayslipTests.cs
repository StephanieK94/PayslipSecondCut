using Generator;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PayslipTestLibrary
{
    public class PayslipTests
    {
        [Fact]
        public void GivenEmployeeAndCalculator_WhenPlayslipCalled_ReturnsGrossIncome()
        {
            Employee employee = new Employee()
            {
                FirstName = "David" ,
                LastName = "Rudd" ,
                Salary = 50000m,
                SuperRate = 0.09m,
                PayPeriod = "01 March - 31 March",
            };

            NZTaxCalculator calculator = new NZTaxCalculator();

            Payslip payslip = new Payslip(employee);

            Assert.Equal("David Rudd", payslip.FullName);
        }
    }
}
