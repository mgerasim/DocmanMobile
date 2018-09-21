using System;
namespace DocmanMobile.Models
{
    /// <summary>
    /// Паспорт
    /// </summary>
    public class Passport
    {
        /// <summary>
        /// Серия паспорта
        /// </summary>
        /// <value>The passport serial.</value>
        public string Serial { get; set; }

        /// <summary>
        /// Номер паспорта
        /// </summary>
        /// <value>The number.</value>
        public string Number { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Passport()
        {
        }
    }
}
