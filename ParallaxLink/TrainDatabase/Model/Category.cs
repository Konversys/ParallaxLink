using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParallaxLink.TrainDatabase.Model
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
        }

        public Category(int id, string title)
        {
            Id = id;
            Title = title;
        }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        [Column("title")]
        public string Title { get; set; }
    }
}
