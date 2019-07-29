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

        public void GetEmployee( string emp )
        {
            string[] employeeInformation = emp.Split( ',' );

            this.FirstName = employeeInformation[0];
        }
    }
}
