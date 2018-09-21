using System;
namespace DocmanMobile.Models
{
    /// <summary>
    /// Адрес
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Район
        /// </summary>
        /// <value>The region.</value>
        public string Region { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        /// <value>The locality.</value>
        public string Locality { get; set; }

        /// <summary>
        ///  Улица
        /// </summary>
        /// <value>The streep.</value>
        public string Street { get; set; }

        /// <summary>
        /// Расстояние
        /// </summary>
        /// <value>The distance.</value>
        public string Distance { get; set; }

        /// <summary>
        /// Дом
        /// </summary>
        /// <value>The house.</value>
        public int House { get; set; }

        /// <summary>
        /// Корпус
        /// </summary>
        /// <value>The corpus.</value>
        public string Corpus { get; set; }

        /// <summary>
        /// Подъезд
        /// </summary>
        /// <value>The entrance.</value>
        public int Entrance { get; set; }

        /// <summary>
        /// Этаж
        /// </summary>
        /// <value>The floor.</value>
        public int Floor { get; set; }

        /// <summary>
        /// Код входной двери
        /// </summary>
        /// <value>The doorcode.</value>
        public string Doorcode { get; set; }

        /// <summary>
        /// Квартира
        /// </summary>
        /// <value>The room.</value>
        public string Room { get; set; }
    }
}
