using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxLink.TrainDatabase.Model
{
    [Table("Products")]
    public class Product
    {
        public Product()
        {
        }

        public Product(int id, string title, double price, int categoryId, string count, string about, string image)
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
        [Column("title")]
        public string Title { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        [Column("price")]
        public double Price { get; set; }
        /// <summary>
        /// Категория
        /// </summary>
        [Column("category")]
        public int CategoryID { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        [Column("count")]
        public string Count { get; set; }
        /// <summary>
        /// Подробности
        /// </summary>
        [Column("About")]
        public string About { get; set; }
        /// <summary>
        /// Изображение
        /// </summary>
        [Column("image")]
        public string Image { get; set; }
    }
}
