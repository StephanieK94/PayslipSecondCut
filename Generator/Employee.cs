using System;
using System.Collections.Generic;
using System.Text;

namespace Generator
{
    public class Employee
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string payPeriod;
        public string PayPeriod
        {
            get { return payPeriod; }
            set { payPeriod = value; }
        }

        private decimal _salary;
        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        private decimal superRate;
        public decimal SuperRate
        {
            get { return superRate; }
            set { superRate = value; }
        }

        private decimal monthlyGrossIncome;
        public decimal MonthlyGrossIncome
        {
            get { return monthlyGrossIncome; }
            set { monthlyGrossIncome = value; }
        }

        private decimal incomeTax;
        public decimal MonthlyIncomeTax
        {
            get { return incomeTax; }
            set { incomeTax = value; }
        }

        private decimal monthlyNetIncome;
        public decimal MonthlyNetIncome
        {
            get { return monthlyNetIncome; }
            set { monthlyNetIncome = value; }
        }

        private decimal super;
        public decimal SuperAmount
        {
            get { return super; }
            set { super = value; }
        }

        public void GetEmployee( string empCsv )
        {
            string[] employeeInformation = empCsv.Split( ',' );

            this.FirstName = employeeInformation[0];
            this.LastName = employeeInformation[1];
            this.Salary = Convert.ToDecimal(employeeInformation[2]);
            this.SuperRate = ConvertSuperRate(employeeInformation[3]);
            this.PayPeriod = employeeInformation[4];
        }

        public void GetEmployeeTaxInformation(ICalculator calculator)
        {
            this.MonthlyGrossIncome = calculator.CalculateMonthlyGrossIncome( this.Salary );
            this.MonthlyIncomeTax = calculator.CalculateMonthlyIncomeTax( Salary );
            this.MonthlyNetIncome = calculator.CalculateMonthlyNetIncome( this.MonthlyGrossIncome , this.MonthlyIncomeTax );
            this.SuperAmount = calculator.CalculateSuperTax( this.MonthlyGrossIncome , this.SuperRate );
        }
        private decimal ConvertSuperRate(string rate)
        {
            var percent = Convert.ToDecimal( rate.TrimEnd( '%' ) );
            return percent / 100;
        }
    }
}
