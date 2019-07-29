using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Generator
{
    public class Payslip
    {
        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        private string[] payslipInformation;
        public string[] PayslipInformation
        {
            get { return payslipInformation; }
            set { payslipInformation = value; }
        }

        public Payslip (Employee employee)
        {
            this.FullName = new string( employee.FirstName + ' ' + employee.LastName );

            this.PayslipInformation = new string[7];
            this.PayslipInformation[0] = FullName;
            this.PayslipInformation[1] = employee.PayPeriod;
            this.PayslipInformation[2] = employee.MonthlyGrossIncome.ToString();
            this.PayslipInformation[3] = employee.MonthlyIncomeTax.ToString();
            this.PayslipInformation[4] = employee.MonthlyNetIncome.ToString();
            this.PayslipInformation[5] = employee.SuperAmount.ToString();
        }

        public void PrintPayslip(string path)
        {
            using ( StreamWriter sw = new StreamWriter( path ) )
            {
                Console.WriteLine( string.Join(',', this.PayslipInformation) );
            }
        }

        
    }
}
