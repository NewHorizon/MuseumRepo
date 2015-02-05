using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Model
{
    /// <summary>
    /// Карточка научного описания
    /// </summary>
    public class Card
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ГИК
        /// </summary>
        public int GIK { get; set; }

        /// <summary>
        /// ИК
        /// </summary>
        public int IK { get; set; }

        /// <summary>
        /// Ид наименования музея из справочника
        /// </summary>
        [Required]
        public short MuseumNameId { get; set; }

        /// <summary>
        /// Номер специальной инвентарной книги
        /// </summary>
        public int? SpecialBookNum { get; set; }

        /// <summary>
        /// Номер негатива
        /// </summary>
        public int? NegativeNum { get; set; }

        /// <summary>
        /// Акт поступления
        /// </summary>
        public string AdmissionAct { get; set; }

        /// <summary>
        /// Ид датировки
        /// </summary>
        public short DatingId { get; set; }

        /// <summary>
        /// Точная датировка
        /// </summary>
        public int ExactDating { get; set; }

        /// <summary>
        /// Дата составления
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Ид деятеля
        /// </summary>
        public int? DoerId { get; set; }

        /// <summary>
        /// Ид наименования предмета
        /// </summary>
        public int SubjectTitleId { get; set; }

        /// <summary>
        /// Ид раздела медицины
        /// </summary>
        public int MedicineSectionId { get; set; }

        /// <summary>
        /// Ид места нахождения
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// Ид материала
        /// </summary>
        public int MaterialId { get; set; }

        /// <summary>
        /// Ид сохранности
        /// </summary>
        public int StateId { get; set; }

        /// <summary>
        /// Размер, вес, проба и т.п.
        /// </summary>
        [StringLength(maximumLength: 30)]
        public string Size { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Тексты, пометки и т.п.
        /// </summary>
        [StringLength(maximumLength: 100)]
        public string Marks { get; set; }

        /// <summary>
        /// Марки, клейма, наклейки, серийные № и т.п.
        /// </summary>
        [StringLength(maximumLength: 30)]
        public string Stickers { get; set; }

        /// <summary>
        /// Место производства
        /// </summary>
        [StringLength(maximumLength: 50)]
        public string ManufacturePlace { get; set; }
        
        /// <summary>
        /// Реставрации
        /// </summary>
        [StringLength(maximumLength: 50)]
        public string Restavrations { get; set; }
        
        /// <summary>
        /// Публикации, использование и т.п.
        /// </summary>
        [StringLength(maximumLength: 50)]
        public string Publications { get; set; }

        /// <summary>
        /// Отметка о выдаче
        /// </summary>
        [StringLength(maximumLength: 30)]
        public string ExtraditionMark { get; set; }

        public virtual MuseumName MuseumName {get; set;}
        public virtual Dating Dating { get; set; }
        public virtual Doer Doer { get; set; }
        public virtual SubjectTitle SubjectTitle { get; set; }
        public virtual MedicineSection MedicineSection { get; set; }
        public virtual Location Location { get; set; }
        public virtual Material Material { get; set; }
        public virtual State State { get; set; }

    }
}
