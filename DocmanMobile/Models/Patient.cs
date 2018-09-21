using System;
namespace DocmanMobile.Models
{
    /// <summary>
    /// Пациент
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        /// <value>The lastname.</value>
        public string Lastname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        /// <value>The firstname.</value>
        public string Firstname { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        /// <value>The secondname.</value>
        public string Secondname { get; set; }

        /// <summary>
        /// контактный номер телефона
        /// </summary>
        /// <value>The phone number.</value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        /// <value>The birthday.</value>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        /// <value>The age.</value>
        public int Age { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        /// <value>The sex.</value>
        public int Sex { get; set; }

        /// <summary>
        /// Паспорт
        /// </summary>
        /// <value>The passport.</value>
        public Passport Passport { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Patient()
        {
        }
    }
}
