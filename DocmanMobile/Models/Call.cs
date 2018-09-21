using System;
namespace DocmanMobile.Models
{
    /// <summary>
    /// Вызов
    /// </summary>
    public class Call
    {
        /// <summary>
        /// Телефон вызывающего
        /// </summary>
        /// <value>The caller phone.</value>
        public string CallerPhone { get; set; }

        /// <summary>
        /// Фамилия вызывающего
        /// </summary>
        /// <value>The who summoned.</value>
        public string WhoSummoned { get; set; }

        /// <summary>
        /// Не представился 
        /// </summary>
        /// <value><c>true</c> if is not introduce; otherwise, <c>false</c>.</value>
        public bool IsNotIntroduce { get; set; }

        /// <summary>
        /// Пациент
        /// </summary>
        /// <value>The patient.</value>
        public Patient Patient { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        /// <value>The address.</value>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the anamnesis.
        /// </summary>
        /// <value>The anamnesis.</value>
        public Anamnesis Anamnesis { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Call()
        {
        }
    }
}
