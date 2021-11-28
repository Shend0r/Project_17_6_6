using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_17_6_6
{
    internal class CalculationSalary : ICalculatorIntrested
    {
        void ICalculatorIntrested.Calculate(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
