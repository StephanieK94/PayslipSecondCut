using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Generator
{
    public class EmployeeReader
    {
        public List<Employee> GetEmployeeList( string pathName, ICalculator calculator )
        {
            List<Employee> employeeList = new List<Employee>();

            using (StreamReader sr = new StreamReader ( pathName) )
            {
                while ( !sr.EndOfStream )
                {
                    Employee emp = new Employee();

                    emp.GetEmployee( sr.ReadLine() );
                    emp.GetEmployeeTaxInformation( calculator );

                    employeeList.Add( emp );
                }
            }

            return employeeList;
        }
    }
}
