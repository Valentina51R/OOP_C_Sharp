namespace Model
{
    /// <summary>
    /// Класс шара.
    /// </summary>
    public class Ball : FigureBase
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        private double _radius;

        /// <summary>
        /// Радиус шара.
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = CheckNumber(value);
            }
        }

        /// <summary>
        /// Тип фигуры.
        /// </summary>
        public override string FigureType
        {
            get
            {
                return $"Шар";
            }
        }

        /// <summary>
        /// Параметры.
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"R = {Radius}";
            }
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Ball()
        { }

        /// <summary>
        /// Метод вывода инфрмации о фигуре.
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return $"Шар: R = {Radius}, V = {Math.Round(Volume, 3)}.";
        }


        /// <summary>
        /// Расчёт объёма шара
        /// </summary>
        /// <returns>volume.</returns>
        public override double Volume =>
            CheckNumber((4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3));
    }
}
