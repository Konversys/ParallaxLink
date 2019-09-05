using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParallaxLink.TrainDatabase.Model
{
    [Table("Products")]
    public class Product : ProductShort
    {
        public Product()
        {
        }

        public Product(int id, string title, double price, int categoryId, string count, string about, string image) : base(title, price, categoryId, count, about, image)
        {
            Id = id;
            Title = title;
            Price = price;
            CategoryID = categoryId;
            Count = count;
            About = about;
            Image = image;
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
    }
}
