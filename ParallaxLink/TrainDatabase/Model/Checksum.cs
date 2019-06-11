using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParallaxLink.TrainDatabase.Model
{
    public class Checksum
    {
        public static readonly string PRODUCT = "products";
        public static readonly string INVENTORY = "inventory";
        public static readonly string DIRECTION = "direction";
        public Checksum(string table, long hash)
        {
            Table = table;
            Hash = hash;
        }

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
