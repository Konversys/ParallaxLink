using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParallaxLink.TrainDatabase.Model
{
    [Table("Directions")]
    public class TrainDirection : IComparable<TrainDirection>
    {
        public TrainDirection(string value, string name, string from, string to, DateTime date)
        {
            Value = value;
            Name = name;
            From = from;
            To = to;
            Date = date;
        }
        /// <summary>
        /// Номер поезда
        /// </summary>
        [Key]
        [Column("value")]
        public string Value { get; set; }
        /// <summary>
        /// Полное имя поезда
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
        /// <summary>
        /// Код станции отправления
        /// </summary>
        [Column("from_")]
        public string From { get; set; }
        /// <summary>
        /// Код станции прибытия
        /// </summary>
        [Column("to_")]
        public string To { get; set; }
        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        [Column("date")]
        public DateTime Date { get; set; }

        public int CompareTo(TrainDirection other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
