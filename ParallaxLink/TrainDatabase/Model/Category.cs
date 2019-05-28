using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
