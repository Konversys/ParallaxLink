using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParallaxLink.TrainDatabase.Model
{
    [Table("Directions")]
    public class Direction : DirectionShort, IComparable<Direction>
    {
        public Direction(int id, string value, string name, string from, string to) : base(value, name, from, to)
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
        public int CompareTo(Direction other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
