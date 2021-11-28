using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_17_6_6
{
    /// <summary>
    /// Аккаунт пользователя и его данные.
    /// </summary>
    internal class Account
    {
        /// <summary>
        /// Тип аккаунта.
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Баланс аккаунта
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// Процентная ставка
        /// </summary>
        public double Interest { get; set; }
    }
}
