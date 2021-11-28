using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_17_6_6
{
    /// <summary>
    /// Интерфейс калькулятора, который подсчитывает процентную ставку
    /// </summary>
    internal interface ICalculatorIntrested
    {
        /// <summary>
        /// Метод ведёт расчет процентной ставки для аккаунта.
        /// </summary>
        /// <param name="account">Аккаунт пользователя, над которым будут производится расчёты.</param>
        void Calculate(Account account);
    }
}
