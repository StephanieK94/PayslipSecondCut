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

            Employee employee = new Employee();
            employee.GetEmployee( emp );

            Assert.Equal( "David" , employee.FirstName );
        }
    }
}
