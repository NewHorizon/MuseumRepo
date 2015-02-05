using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Model
{
    /// <summary>
    /// Деятель
    /// </summary>
    public class Doer
    {
        public short Id { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Otchestvo { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Дата смерти
        /// </summary>
        public DateTime? DeathDate { get; set; }

        /// <summary>
        /// Период работы
        /// </summary>
        public string WorkPeriod { get; set; }
    }
}
