using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxLink.TrainDatabase.Model
{
    class Checksum
    {
        /// <summary>
        /// Таблица
        /// </summary>
        [Key]
        [Column("Table")]
        public string Table { get; set; }
        /// <summary>
        /// Контрольная сумма
        /// </summary>
        [Column("Checksum")]
        public long Hash { get; set; }
    }
}
