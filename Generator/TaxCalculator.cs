using System;
using System.Collections.Generic;
using System.Text;

namespace Generator
{
    public class TaxCalculator : ICalculator
    {
        public decimal CalculateGrossIncome ( decimal salary )
        {
            return salary;
        }
    }
}
