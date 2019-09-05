using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParallaxLink.TrainDatabase.Model
{
    [Table("Items")]
    public class Inventory: InventoryShort
    {
        public Inventory(string title) : base(title)
        {
            Title = title;
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
