using System;
using System.Collections.Generic;
using System.Text;

namespace Generator
{
    interface ICalculator
    {
        decimal CalculateMonthlyGrossIncome ( decimal yearlySalary );
        decimal CalculateIncomeTax ( decimal yearlySalary );
        decimal CalculateMonthlyNetIncome ( decimal monthlyIncome, decimal netTaxAmount );
    }
}
