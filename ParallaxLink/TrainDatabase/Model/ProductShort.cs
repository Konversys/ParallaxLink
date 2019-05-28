using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxLink.TrainDatabase.Model
{
    public class ProductShort
    {
        static List<Category> Categories;
        static List<Category> GetCategories()
        {
            if (Categories == null)
            {
                Categories = ParallaxController.GetCategories();
            }
            return Categories;
        }

        static string GetCategoryTitleById(int id)
        {
            return GetCategories().Where(x => x.Id == id).FirstOrDefault().Title;
        }

        public ProductShort(string title, double price, string category, string count, string about, string image)
        {
            Title = title;
            Price = price;
            Category = category;
            Count = count;
            About = about;
            Image = image;
        }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Категория
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public string Count { get; set; }
        /// <summary>
        /// Подробности
        /// </summary>
        public string About { get; set; }
        /// <summary>
        /// Изображение
        /// </summary>
        public string Image { get; set; }

        public static ProductShort Convert(Product product)
        {
            return new ProductShort(product.Title, product.Price, GetCategoryTitleById(product.CategoryID), product.Count, product.About, product.Image);
        }
    }
}
