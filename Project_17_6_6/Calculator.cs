using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_17_6_6
{
    /// <summary>
    /// Класс содержащий методы для произведения расчётов.
    /// </summary>
    internal class Calculator
    {
        /// <summary>
        /// Метод который возвращает тип производимого расчёта в зависимости от типа аккаунта. 
        /// </summary>
        /// <param name="account"></param>
        /// <returns>ICalculatorIntrested</returns>
        private protected ICalculatorIntrested GetType(Account account)
        {
            ICalculatorIntrested calculatorIntrested = default(ICalculatorIntrested);

            switch (account.Type)
            {
                case "default":
                    calculatorIntrested = new CalculationDefault();
                    break;

                case "salary":
                    calculatorIntrested = new CalculationSalary();
                    break;
            }

            return calculatorIntrested;
        }

        /// <summary>
        /// Метод для расчёта процентной ставки.
        /// </summary>
        /// <param name="account">Аккаунт пользователя, над которым будут производится расчёты.</param>
        public void CalculateIntrested(Account account)
        {
            ICalculatorIntrested calculatorIntrested = GetType(account);

            calculatorIntrested.Calculate(account);
        }
    }
}
