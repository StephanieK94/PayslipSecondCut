using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Generator
{
    public class Payslip
    {
        private Employee _employee;
        private string fullName;
        public string FullName { get { return fullName; } set { fullName = value; } }
        


        public Payslip (Employee employee)
        {
            _employee = employee;
            FullName = new string( employee.FirstName + ' ' + employee.LastName );
        }

        public void PrintPayslip(string path)
        {
            

            using ( StreamWriter sw = new StreamWriter( path ) )
            {
                Console.WriteLine( String.Join(',', _employee) );
            }
        }

        
    }
}
