using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Generator
{
    class Program
    {
        static void Main ( string[] args )
        {
            //string inputPathName = Path.Combine( Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location ) , "EmployeesList.csv" );
            string dir = Directory.GetParent( Directory.GetCurrentDirectory() ).Parent.Parent.Parent.FullName;
            string inputPathName = $"{dir}\\Generator\\EmployeesList.csv";

            EmployeeReader fileReader = new EmployeeReader();
            NZTaxCalculator nzTaxCalculator = new NZTaxCalculator();

            List<Employee> employeeList = fileReader.GetEmployeeList( inputPathName, nzTaxCalculator );

            string outputPathName = $"{dir}\\Generator\\PayslipsList.csv";

            foreach (Employee employee in employeeList)
            {
                Payslip monthlyPayslip = new Payslip( employee );
                monthlyPayslip.PrintPayslip( outputPathName );
            }
        }
    }
}
