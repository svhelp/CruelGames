using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Actions
{
    /// <summary>
    /// Результат действия.
    /// </summary>
    public class ActionResultBase
    {
        public ActionResultBase()
        {
        }

        public ActionResultBase(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Успешно ли.
        /// </summary>
        public bool IsSuccessful { get; set; } = true;

        /// <summary>
        /// Сообщение об ошибке.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
