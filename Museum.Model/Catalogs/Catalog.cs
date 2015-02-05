using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Model
{
    /// <summary>
    /// Абстрактный тип справочников в системе
    /// </summary>
    public abstract class Catalog
    {
        public short Id { get; set; }

        [Required]
        public virtual string Title { get; set; }
    }
}
