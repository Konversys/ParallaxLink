namespace ParallaxLink.TrainDatabase.Model
{
    public class DirectionShort
    {
        public DirectionShort(string value, string name, string from, string to)
        {
            Value = value;
            Name = name;
            From = from;
            To = to;
        }
        /// <summary>
        /// Номер поезда
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Полное имя поезда
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Код станции отправления
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Код станции прибытия
        /// </summary>
        public string To { get; set; }
    }
}