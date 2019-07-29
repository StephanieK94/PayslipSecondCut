using System;

namespace Generator
{
    public class NZTaxCalculator : ICalculator
    {
        public decimal CalculateMonthlyGrossIncome ( decimal yearlySalary )
        {
            if(yearlySalary> 0) return Math.Round( yearlySalary / 12 );
            return 0;
        }

        public decimal CalculateIncomeTax ( decimal yearlySalary )
        {
            decimal monthlyIncomeTax = 0;

            if ( yearlySalary <= 18200 ) return monthlyIncomeTax;
            if ( yearlySalary >= 18201 && yearlySalary <= 37000 )
            {
                monthlyIncomeTax = ( yearlySalary - 18200 ) * 0.19m;
            }
            else if ( yearlySalary >= 37001 && yearlySalary <= 80000 )
            {
                monthlyIncomeTax = 3572 + ( ( yearlySalary - 37000 ) * 0.325m );
            }
            else if ( yearlySalary >= 80001 && yearlySalary <= 180000 )
            {
                monthlyIncomeTax = 17547 + ( ( yearlySalary - 37000 ) * 0.325m );
            }
            else
            {
                monthlyIncomeTax = 54547 + ( ( yearlySalary - 180000 ) * 0.45m );
            }
            return Math.Round( monthlyIncomeTax );
        }

        public decimal CalculateMonthlyNetIncome ( decimal monthlyIncome, decimal netTax )
        {
            return Math.Round( monthlyIncome - (netTax/12) );
        }

        public decimal CalculateSuperTax ( decimal monthlyIncome, decimal superRate )
        {
            return Math.Round( monthlyIncome * superRate );
        }
    }
}
