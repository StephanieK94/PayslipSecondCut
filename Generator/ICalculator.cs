using System;
using System.Collections.Generic;
using System.Text;

namespace Generator
{
    public interface ICalculator
    {
        decimal CalculateMonthlyGrossIncome ( decimal yearlySalary );
        decimal CalculateMonthlyIncomeTax ( decimal yearlySalary );
        decimal CalculateMonthlyNetIncome ( decimal monthlyIncome, decimal netTaxAmount );
        decimal CalculateSuperTax ( decimal monthlyIncome, decimal superRate );
    }
}
