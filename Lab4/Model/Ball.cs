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
        /// Консруктор.
        /// </summary>
        /// <param name="radius"></param>
        public Ball(double radius)
        {
            Radius = radius;
        }

        public Ball()
        { }

        /// <summary>
        /// Метод вывода инфрмации о фигуре.
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return $"Шар радиусом {Radius} имеет объём {Volume}.";
        }


        /// <summary>
        /// Расчёт объёма шара
        /// </summary>
        /// <returns>volume.</returns>
        public override double Volume =>
            (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }
}
