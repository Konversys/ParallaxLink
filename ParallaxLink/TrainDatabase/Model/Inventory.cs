using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParallaxLink.TrainDatabase.Model
{
    [Table("Items")]
    public class Inventory
    {
        [Key]
        [Column("title")]
        public string title;
    }
}
