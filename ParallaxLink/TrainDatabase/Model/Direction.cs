using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParallaxLink.TrainDatabase.Model
{
    [Table("Directions")]
    public class Direction : IComparable<Direction>
    {
        public Direction(int id, string value, string name, string from, string to)
        {
            Id = id;
            Value = value;
            Name = name;
            From = from;
            To = to;
        }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Номер поезда
        /// </summary>
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

        public int CompareTo(Direction other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
