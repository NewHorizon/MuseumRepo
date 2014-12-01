using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Model
{
    public class MedicineSection
    {
        /// <summary>
        /// Ключ в таблице названий мед.специальностей
        /// </summary>
        public short MedicineSectionTitleId { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Ид карты научного описания
        /// </summary>
        public int CardId { get; set; }
    }
}
